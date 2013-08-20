using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory.Xml;
using Spring.Objects.Factory.Config;
using Spring.Objects.Factory.Support;
using Common.Logging;
using Common.Logging.Log4Net;



namespace SpringExample.IocQuickStart.MovieFinder
{
    class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            try
            {
                IApplicationContext ctx = ContextRegistry.GetContext();

                MovieLister lister = (MovieLister)ctx.GetObject("MyMovieLister");
                Movie[] movies = lister.MoviesDirectedBy("Roberto Benigni");
                Log.Debug("Searching for movie...");
                foreach (Movie movie in movies)
                {
                    Log.Debug(
                        string.Format("Movie Title = '{0}', Director = '{1}'.",
                                      movie.Title, movie.Director));
                }
                Log.Debug("MovieApp Done.");
            }
            catch (Exception e)
            {
                Log.Error("Movie Finder is broken.", e);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("--- hit <return> to quit ---");
                Console.WriteLine("Hello");
                Console.ReadLine();
            }
        }
    }
}
