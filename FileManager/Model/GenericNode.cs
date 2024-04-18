using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Model
{
    internal class GenericNode<T>
    {
        public T? Value { get; set; }
        public int Count{ get; set; }
        public GenericNode<T>? Next{ get; set; }
        public GenericNode<T>? Prev{ get; set; }
    }
}
