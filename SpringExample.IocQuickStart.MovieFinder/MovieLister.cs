using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Objects.Factory.Attributes;
using System.Collections;

namespace SpringExample.IocQuickStart.MovieFinder
{
    public class MovieLister
    {
        public MovieLister()
        {
        }

        [Required]
        public IMovieFinder MovieFinder
        {
            set;
            get;
        }

        public Movie[] MoviesDirectedBy(string director)
        {
            IList allMovies = MovieFinder.FindAll();
            IList movies = new ArrayList();
            foreach (Movie item in allMovies)
            {
                if (string.Equals(item.Director, director, StringComparison.OrdinalIgnoreCase))
                {
                    movies.Add(item);
                }
            }

            return (Movie[])ArrayList.Adapter(movies).ToArray(typeof(Movie));
        }
    }
}
