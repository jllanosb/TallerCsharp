using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Algoritmos con Estructuras de Control Basicas--");
            /*
             Calcular el IGV cuando el monto de venta sea superior a 999            
             */

            //Declarar Variables
            //1ra forma
            double impuesto;
            //2da forma
            double igv = 0.18; // compra

            Console.WriteLine("Ingrese el valor de la venta: ");
            var monto = double.Parse(Console.ReadLine());

            if (monto > 999)
            {
                impuesto = monto * igv;
                Console.WriteLine($"La venta de {monto} soles genera {impuesto} soles de IGV");
            }

            Console.WriteLine("Condicional Doble");

            /* De caso anterior si la venta es menor mostrar solo 1% dscto
             */

            if (monto > 999)
            {
                impuesto = monto * igv;
                Console.WriteLine($"La venta de {monto} soles genera {impuesto} soles de IGV");
            }
            else {
                Console.WriteLine($" Se obtuvo un Dscto 1% y pagara solamente {monto*0.99} soles");
            }

            Console.WriteLine("Condicional Anidado");

            /*
             Un niño dislexico quiere saber que vocal es al indicar un numero (1-5)
             */

            Console.WriteLine("Ingresa un numero [1-5]: ");
            var num = int.Parse(Console.ReadLine());

            if (num == 1) {
                Console.WriteLine("La vocal es la A");
            }
            else if (num == 2) {
                Console.WriteLine("La vocal es la E");
            }
            else if (num == 3) {
                Console.WriteLine("La vocal es la I");
            }
            else if (num == 4) {
                Console.WriteLine("La vocal es la O");
            }
            else if (num == 5) {
                Console.WriteLine("La vocal es la U");
            }
            else {
                Console.WriteLine("Numero Incorrecto");
            }








                Console.ReadKey();
        }
    }
}
