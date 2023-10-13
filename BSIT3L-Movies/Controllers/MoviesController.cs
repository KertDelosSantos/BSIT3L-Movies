using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;
namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;

        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
            new MovieViewModel {ImageURL = "/images/1.jpg", Id = 1, Name = "The Social Network ", Rating = "5", ReleaseYear = 2010, Genre = "Romance/Drama" },
            new MovieViewModel {ImageURL = "/images/2.jpg", Id = 2, Name = "Pirates of Silicon Valley", Rating = "4", ReleaseYear = 1999, Genre = "Science Fiction/Thriller" },
            new MovieViewModel {ImageURL = "/images/3.jpg",  Id = 3, Name = "Hackers", Rating = "5", ReleaseYear = 1995, Genre = "Drama" },
            new MovieViewModel {ImageURL = "/images/4.jpg",  Id = 4, Name = "WarGames ", Rating = "5", ReleaseYear = 1983, Genre = "Romance/Drama" },
            new MovieViewModel {ImageURL = "/images/5.jpg",  Id = 5, Name = "Tron ", Rating = "4", ReleaseYear = 1982, Genre = "Science Fiction/Thriller" },
            new MovieViewModel {ImageURL = "/images/6.jpg",  Id = 6, Name = "The Imitation Game", Rating = "5", ReleaseYear = 2014, Genre = "Drama" },
            new MovieViewModel {ImageURL = "/images/7.jpg",  Id = 7, Name = "Jobs ", Rating = "5", ReleaseYear = 2013, Genre = "Romance/Drama" },
            new MovieViewModel {ImageURL = "/images/8.jpg",  Id = 8, Name = "Steve Jobs", Rating = "4", ReleaseYear = 2015, Genre = "Science Fiction/Thriller" },
            new MovieViewModel {ImageURL = "/images/9.jpg",  Id = 9, Name = "Ex Machina", Rating = "5", ReleaseYear = 2014, Genre = "Drama" },
            new MovieViewModel {ImageURL = "/images/10.jpg",  Id = 10, Name = "Mr. Robot ", Rating = "5", ReleaseYear = 2015, Genre = "Romance/Drama" },
            new MovieViewModel {ImageURL = "/images/11.jpg",  Id = 11, Name = "Black Mirror: Bandersnatch ", Rating = "4", ReleaseYear = 2018, Genre = "Science Fiction/Thriller" },
            new MovieViewModel {ImageURL = "/images/12.jpg",  Id = 12, Name = "Antitrust ", Rating = "5", ReleaseYear = 2001, Genre = "Drama" },
            new MovieViewModel {ImageURL = "/images/13.jpg",  Id = 13, Name = "Transcendence  ", Rating = "5", ReleaseYear = 2014, Genre = "Drama" },
            new MovieViewModel {ImageURL = "/images/14.jpg",  Id = 14, Name = "Sneakers ", Rating = "5", ReleaseYear = 1992, Genre = "Romance/Drama" },
            new MovieViewModel {ImageURL = "/images/15.jpg",  Id = 15, Name = "The Matrix ", Rating = "4", ReleaseYear = 1999, Genre = "Science Fiction/Thriller" },            
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

