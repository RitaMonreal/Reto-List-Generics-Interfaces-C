using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interfaces_List
{
    internal class Node<T>
    {
        public T data; //Ya son package-private
        public Node<T> next;
        public Node<T> previous;
        public Node(T data)//Le puse el public
        {
            this.data = data;
        }
    }
}
