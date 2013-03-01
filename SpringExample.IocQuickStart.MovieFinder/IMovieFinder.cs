using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringExample.IocQuickStart.MovieFinder
{
    public interface IMovieFinder
    {
        IList FindAll();
    }
}
