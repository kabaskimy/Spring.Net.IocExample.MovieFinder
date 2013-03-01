using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace SpringExample.IocQuickStart.MovieFinder
{
    public class ColonDelimitedMovieFinder:IMovieFinder
    {
        private static readonly char[] Delimeter = new char[] { ':' };

        private FileInfo _movieFile;
        private IList _movies;

        /// <summary>
        /// Creates a new instance of the
        /// <see cref="Spring.IocQuickStart.MovieFinder.ColonDelimitedMovieFinder"/> class.
        /// </summary>
        /// <param name="file">
        /// The file containing colon delimited movies.
        /// </param>
        public ColonDelimitedMovieFinder(FileInfo file)
        {
            MovieFile = file;
        }

        /// <summary>
        /// The file containing colon delimited movies.
        /// </summary>
        /// <value>
        /// A <see cref="System.IO.FileInfo"/> pointing to the file containing
        /// colon delimited movies.
        /// </value>
        public FileInfo MovieFile
        {
            get
            {
                return _movieFile;
            }
            set
            {
                _movieFile = value;
                if (_movieFile != null && _movieFile.Exists)
                {
                    InitList();
                }
            }
        }

        /// <summary>
        /// Finds all of the movies stored in this
        /// <see cref="Spring.IocQuickStart.MovieFinder.IMovieFinder"/> implementation.
        /// </summary>
        /// <returns>
        /// All of the movies stored in this
        /// <see cref="Spring.IocQuickStart.MovieFinder.IMovieFinder"/> implementation.
        /// </returns>
        public IList FindAll()
        {
            return _movies;
        }

        /// <summary>
        /// Loads all of the movies in the file referred to by <c>MovieFile</c>.
        /// </summary>
        private void InitList()
        {
            _movies = new ArrayList();
            using (StreamReader reader = MovieFile.OpenText())
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tuple = line.Split(Delimeter);
                    Movie movie = new Movie(tuple[0], tuple[1]);
                    _movies.Add(movie);
                }
            }
        }
    }
}
