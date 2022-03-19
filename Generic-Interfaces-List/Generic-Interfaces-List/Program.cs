using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Interfaces_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma(new LinkedList<String>(), new LinkedList<String>(), new LinkedList<String>());
            Firma(new ArrayList<String>(), new ArrayList<String>(), new ArrayList<String>());
        }

        public static void Firma(List<String> team1, List<String> team2, List<String> team3)
        {
            team1.addAtTail("Jesús");
            team1.addAtTail("Salomón");
            team1.addAtTail("Yael");

            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");

            team3.addAtFront("Imelda");
            Console.WriteLine("\n>>Team 1 original\n");

            Iterator<String> iterator;

            iterator = team1.getIterator();

            while (iterator.hasNext())//Mientras sea diferente de nulo, o sea que haya elementos en la lista
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine("\n>>Team 2 original\n");

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            Console.WriteLine("\n>>Team 1 modificado\n");

            team1.remove(0);
            team1.addAtFront("Rebeca");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            team2.remove(2);
            team2.addAtTail("Rita<3");
            Console.WriteLine("\n>>Team 2 Modificado\n");
            Console.WriteLine("Team 2 tiene: " + team2.getSize() + " integrantes"); // debe imprimir "Team 2 tiene 3 integrantes"

            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            team3.remove(0);
            team3.remove(0); //Ya no existe, pero debería seguir jalando
            Console.WriteLine("\n>>Team 3 original\n");
            team3.addAtTail("Tadeo");
            team3.addAtFront("Isai");

            Console.WriteLine("Team 3 tiene: " + team3.getSize() + " integrantes"); // debe imprimir "Team 3 tiene 2 integrantes"

            iterator = team3.getIterator();
            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }

            if (team1.getAt(1).Equals("Salomón"))
            {
                team1.setAt(1, "Luis");
            }
            Console.WriteLine("\n>>Team 1 Modificado\n");
            Console.WriteLine("Team 1 tiene: " + team1.getSize() + " integrantes"); // debe imprimir "Team 1 tiene 3 integrantes"

            iterator = team1.getIterator();
            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);
            }
        }
            
    }
}

