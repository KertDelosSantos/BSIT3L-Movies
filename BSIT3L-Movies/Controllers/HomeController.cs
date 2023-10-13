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
            new MovieViewModel {Name = "The Social Network ", Id = 1},
            new MovieViewModel {Name = "Pirates of Silicon Valley", Id = 2},
            new MovieViewModel {Name = "Hackers",  Id = 3},
            new MovieViewModel {Name = "WarGames ",  Id = 4},
            new MovieViewModel {Name = "Tron ",  Id = 5},
            new MovieViewModel {Name = "The Imitation Game",  Id = 6},
            new MovieViewModel {Name = "Jobs ",  Id = 7},
            new MovieViewModel {Name = "Steve Jobs",  Id = 8},
            new MovieViewModel {Name = "Ex Machina",  Id = 9},
            new MovieViewModel {Name = "Mr. Robot ",  Id = 10},
            new MovieViewModel {Name = "Black Mirror: Bandersnatch ",  Id = 11},
            new MovieViewModel {Name = "Antitrust ",  Id = 12},
            new MovieViewModel {Name = "Transcendence  ",  Id = 13},
            new MovieViewModel {Name = "Sneakers ",  Id = 14},
            new MovieViewModel {Name = "The Matrix ",  Id = 15},
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

