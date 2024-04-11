using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccounApp.Εxceptions
{
    internal class InvalidSsnException : Exception
    {
        public InvalidSsnException(string ssn) :base("SSN: " + ssn + " is not valid!") 
        {
            
        }
    }
}
