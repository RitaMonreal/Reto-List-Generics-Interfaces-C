using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interfaces_List
{
    internal class ArrayList <T> : List<T>
    {
        public const int DEFAULT_SIZE = 2;
        private T[] array;
        private int size;

        public static String getName()
        {
            return "ArrayList";
        }

        public ArrayList()
        {
            array = new object[DEFAULT_SIZE] as T[];
        }

        public ArrayList(int size)
        {
            array = new object[size] as T[];
        }

        public void addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseArraySize();
            }

            array[size] = data;
            size++;
        }

        public void addAtFront(T data)
        {

            if (size == array.Length)
            {
                increaseArraySize();
            }

            if (size >= 0)
            {
                Array.Copy(array, 0, array, 1, size);//AQUI LE MOVI Y LE PUSE MAYUSCULASSS
            }
            array[0] = data;
            size++;
        }

        public void remove(int index)
        {

            if (index < 0 || index >= size)
            {
                return;
            }

            if (size - 1 - index >= 0)
            {
                Array.Copy(array, index + 1, array, index, size - 1 - index);
            }

            array[size - 1] = default(T);
            size--;
        }

        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }

        public void setAt(int index, T data)
        {
            if (index >= 0 && index < size)
            {
                array[index] = data;
            }
        }

        public T getAt(int index)
        {
            return index >= 0 && index < size ? array[index] : default(T);
        }

        public Iterator <T> getIterator()
        {
            return new ArrayListIterator<T>(this);
        }

        public int getSize()
        {
            return size;
        }

        private void increaseArraySize()
        {
            T[] newArray = new object[array.Length * 2] as T[];


            for (int i = 0; i < size; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }
}
