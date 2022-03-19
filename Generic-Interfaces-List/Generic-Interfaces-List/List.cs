using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interfaces_List
{
    interface List <T>
    {
        void addAtTail(T data);//Poner el modificador de acceso "public" es redundante ya que es un contrato que debe ser publico (chiste de abogados)
        void addAtFront(T data);//También son abstractos, pero no se les coloca ya que es redundante
        void remove(int index);
        void removeAll();
        void setAt(int index, T data);
        T getAt(int index);
        Iterator<T> getIterator();
        int getSize();
    }
}
