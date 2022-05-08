using System;

namespace Tema3Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul!");
            double numar = int.Parse(Console.ReadLine());
            double aux = numar;

            numar = (Math.Sqrt(numar));

             if (numar * numar == aux)
             {
                Console.WriteLine("Este patrat perfect");
             }
             else
            {
                Console.WriteLine("Nu este patrat perfect");
            }


        }
    }
}
