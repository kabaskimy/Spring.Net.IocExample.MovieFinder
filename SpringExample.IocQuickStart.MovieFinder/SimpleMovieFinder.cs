using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SpringExample.IocQuickStart.MovieFinder
{
    public class SimpleMovieFinder:IMovieFinder
    {
        private IList _movieList;

        public SimpleMovieFinder()
        {
            InitList();
        }

        public void AddMovie(Movie item)
        {
            _movieList.Add(item);
        }

        private void InitList()
        {
            _movieList = new ArrayList();
            _movieList.Add(new Movie("La vita e bella", "Roberto Benigni"));
        }

        public IList FindAll()
        {
            return _movieList;
        }
    }
}
