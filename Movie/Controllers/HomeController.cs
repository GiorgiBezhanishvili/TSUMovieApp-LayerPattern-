using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movie.Models;
using Services.Contracts;
using DAL.Entities;
using Newtonsoft.Json;

namespace Movie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUOW _service;

        public HomeController(ILogger<HomeController> logger, IUOW service)
        {
            _logger = logger;
            _service = service;
        }

        public object Index()
        {
            //DAL.Entities.Movie movie = new DAL.Entities.Movie();
            //movie.DirectorId = 4;
            //movie.Thumb = "...";
            //movie.Title = "test - title";
            //movie.Description = "test - description";

            //_service.Movie.Create(movie);
            //_service.Commit();


            var movie = _service.Movie.GetMovieWithDirector();

            return $"{movie.Director.Firstname} {movie.Director.Lastname}";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
