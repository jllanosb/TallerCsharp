using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algoritmo Condicional Multiple");
            /*
             Vocales para ayudar al niño Dislexico
             */

            Console.WriteLine("Ingrese un numero [1-5]");
            var num = int.Parse(Console.ReadLine());

            switch (num) {
                case 1: Console.WriteLine("La vocal es la A"); break;
                case 2: Console.WriteLine("La vocal es la E"); break;
                case 3: Console.WriteLine("La vocal es la I"); break;
                case 4: Console.WriteLine("La vocal es la O"); break;
                case 5: Console.WriteLine("La vocal es la U"); break;
                default: Console.WriteLine("Numero incorrecto"); break;
            }

        }
    }
}
