using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpSpaceXApp.Exceptions
{

    /// <summary>
    /// Exception if the SpaceX API is not responding
    /// </summary>
    public class APIConnectionException : Exception
    {
        public APIConnectionException (string message) : base(message)
        {
        }
    }
}
