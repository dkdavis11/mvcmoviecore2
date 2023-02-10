using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcmoviecore2.Models;
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
        public async Task<IActionResult> GetUsers()
        {
            if (dbConn2 == null)
                dbConn2 = configuration.GetValue<string>("ConnectionStrings:Default");

            using var connection = new MySqlConnection(dbConn2);
            await connection.OpenAsync();
            using var command = new MySqlCommand("SELECT * FROM movies;", connection);

            //string dbConn = configuration.GetSection("MySettings").GetSection("DbConnection").Value;
            using var reader = await command.ExecuteReaderAsync();
            MovieModel model = new MovieModel();
            var list = new List<MovieModel>();
            while (await reader.ReadAsync())
            {
                Console.WriteLine(reader.GetInt16(0));
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetDateTime(2));
                Console.WriteLine(reader.GetString(3));
                Console.WriteLine(reader.GetDecimal(4));
                list = new List<MovieModel>();
            }


            return Ok(list);
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

