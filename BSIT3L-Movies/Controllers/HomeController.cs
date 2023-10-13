using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel {ImageURL = "/images/1.jpg",Name = "The Social Network ", Id = 1},
            new MovieViewModel {ImageURL = "/images/2.jpg",Name = "Pirates of Silicon Valley", Id = 2},
            new MovieViewModel {ImageURL = "/images/3.jpg", Name = "Hackers",  Id = 3},
            new MovieViewModel {ImageURL = "/images/4.jpg", Name = "WarGames ",  Id = 4},
            new MovieViewModel {ImageURL = "/images/5.jpg", Name = "Tron ",  Id = 5},
            new MovieViewModel {ImageURL = "/images/6.jpg", Name = "The Imitation Game",  Id = 6},
            new MovieViewModel {ImageURL = "/images/7.jpg", Name = "Jobs ",  Id = 7},
            new MovieViewModel {ImageURL = "/images/8.jpg", Name = "Steve Jobs",  Id = 8},
            new MovieViewModel {ImageURL = "/images/9.jpg", Name = "Ex Machina",  Id = 9},
            new MovieViewModel {ImageURL = "/images/10.jpg", Name = "Mr. Robot ",  Id = 10},
            new MovieViewModel {ImageURL = "/images/11.jpg", Name = "Black Mirror: Bandersnatch ",  Id = 11},
            new MovieViewModel {ImageURL = "/images/12.jpg", Name = "Antitrust ",  Id = 12},
            new MovieViewModel {ImageURL = "/images/13.jpg", Name = "Transcendence  ",  Id = 13},
            new MovieViewModel {ImageURL = "/images/14.jpg", Name = "Sneakers ",  Id = 14},
            new MovieViewModel {ImageURL = "/images/15.jpg", Name = "The Matrix ",  Id = 15},
            };
    }

    public IActionResult Index()
    {
        return View(_movies);
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

