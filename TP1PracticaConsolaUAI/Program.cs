using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1PracticaConsolaUAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NumeroString;
            string Numero2String;
            Console.WriteLine("Ingrese un número por favor: ");
            NumeroString = Console.ReadLine();
            Console.WriteLine("Ingrese otro número por favor: ");
            Numero2String = Console.ReadLine();
            int cvrtNumero = Convert.ToInt32(NumeroString);
            int cvrtNumero2 = Convert.ToInt32(Numero2String);
            Console.WriteLine("La suma es {0} ", cvrtNumero + cvrtNumero2);
            Console.ReadKey();

        }
    }
}
