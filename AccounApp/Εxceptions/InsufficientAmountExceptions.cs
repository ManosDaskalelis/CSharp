using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccounApp.Εxceptions
{
    internal class InsufficientAmountExceptions : Exception
    {
        public InsufficientAmountExceptions(string s) : base(s) 
        {
            
        }
        
    }
}
