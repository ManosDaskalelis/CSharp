using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Model
{
    internal class DDList<T>
    {
        public GenericNode<T> Head { get; set; }
        public GenericNode<T> Tail { get; set; }

        public void InserFirst(T t)
        {
            GenericNode<T> tmp = new()
            {
                Value = t,
                Count = 1,
                Next = Head,
                Prev = null,
            };

            Tail = tmp;
            Tail.Next = null;

            if (IsEmpty())
            {
                Tail = tmp;
            }

            Head = tmp;
        }
        public void InserLast(T t)
        {
            if (Head is null)
            {
                InserFirst(t);
                return;
            }
        }

        public bool IsEmpty()
        {
            return Head == null && Tail == null;
        }

    }
}
