using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcmoviecore2.Controllers
{
    public class MovieController : Controller
    {

        private IConfiguration configuration;
        public static string dbConn2 = null;

        public MovieController(IConfiguration iConfig)
        {
            configuration = iConfig;
            
        }


        [HttpGet]
        public IActionResult GetUsers()
        {
          if (dbConn2== null)
            dbConn2 = configuration.GetValue<string>("ConnectionStrings:Default");

            using var connection = new MySqlConnection(dbConn2);
            connection.OpenAsync();
            using var command = new MySqlCommand("SELECT field FROM movie;", connection);

            //string dbConn = configuration.GetSection("MySettings").GetSection("DbConnection").Value;
            var list = new List<string>();
            list.Add("John");
            list.Add("Doe");
            return Ok(list);
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

