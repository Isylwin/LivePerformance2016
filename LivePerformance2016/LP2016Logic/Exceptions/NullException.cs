using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2016Logic.Exceptions
{
    public class NullException : Exception
    {
        public NullException(string message) : base(message)
        {
            
        }
    }
}
