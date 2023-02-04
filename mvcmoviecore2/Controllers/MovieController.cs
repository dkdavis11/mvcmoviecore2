using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvcmoviecore2.Controllers
{
    public class MovieController : Controller
    {

        private IConfiguration configuration;

        public MovieController(IConfiguration iConfig)
        {
            configuration = iConfig;
        }


        [HttpGet]
        public IActionResult GetUsers()
        {
            string dbConn2 = configuration.GetValue<string>("ConnectionStrings:Default");
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

