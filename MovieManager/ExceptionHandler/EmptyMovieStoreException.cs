using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager.ExceptionHandler
{
    internal class EmptyMovieStoreException : Exception
    {
        public EmptyMovieStoreException(string msg) : base(msg)
        {
        }
    }
}
