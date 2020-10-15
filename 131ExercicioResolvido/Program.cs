using System;
using System.Collections.Generic;

using _131ExercicioResolvido.Entities;

namespace _131ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employe> list = new List<Employe>(); 

            Console.WriteLine("Enter the number of employes: ");

            int n = int.Parse( Console.ReadLine() );

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Employe" + i + " data: ");

                Console.WriteLine("OutSourced: (y/n)");

                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");

                string name = Console.ReadLine();

                Console.WriteLine("Hours: ");

                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per hours: ");

                double valuePerHours = double.Parse(Console.ReadLine());


                if( ch == 'y')
                {
                    Console.WriteLine("Additional charge: ");

                    double additionalCharge = double.Parse(Console.ReadLine());

                    list.Add( new OutSourceEmployes(name, hours, valuePerHours, additionalCharge ));

                }
                else
                {

                    list.Add(new Employe(name, hours, valuePerHours));

                }

            }

            Console.WriteLine();
            Console.WriteLine();

            foreach(Employe emp in list)
            {

                Console.WriteLine(emp.Name + " R$ "+ emp.Payment().ToString("F2"));

            }
            

        }
    }
}
