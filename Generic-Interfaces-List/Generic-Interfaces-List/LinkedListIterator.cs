using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interfaces_List
{
    internal class LinkedListIterator<T>: Iterator<T>
    {
        public Node<T> currentNode;//Le puse public

        public LinkedListIterator(Node<T> startNode)//Le puse public
        {
            currentNode = startNode;
        }

        public Boolean hasNext()//Puse Boolean con mayuscula la primera letra
        {
            return currentNode != null;
        }

        public T next()
        {
            T data = currentNode.data;
            currentNode = currentNode.next;
            return data;
        }
    }
}
