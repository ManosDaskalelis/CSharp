using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Service
{
    internal interface IMovable
    {
        //public abstract
        void Move5();
        
        void Move10()
        {
            Console.WriteLine("Move 10 units");
        }
    }
}
