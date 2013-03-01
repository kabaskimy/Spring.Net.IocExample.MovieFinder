using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringExample.IocQuickStart.MovieFinder
{
    public class Movie
    {
        private string _title;
        private string _director;

        public Movie(string title, string director)
        {
            _title = title;
            _director = director;
        }

        public string Title
        {
            set
            {
                _title = value;
            }
            get
            {
                return _title;
            }
        }

        public string Director
        {
            set
            {
                _director = value;
            }
            get
            {
                return _director;
            }
        }
    }
}
