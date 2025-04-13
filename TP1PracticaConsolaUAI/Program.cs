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
            // Ejercicio 1
            /*
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
            */

            // Ejercicio 2
            // El detalle es que le agregue una validacion de Parse
            // Documentacion: https://learn.microsoft.com/es-es/dotnet/api/system.enum.tryparse?view=net-9.0
            // Ejemplo: https://learn.microsoft.com/es-es/dotnet/api/system.enum.tryparse?view=net-9.0#:~:text=Ejemplos-,En%20el%20ejemplo%20siguiente%20se%20define%20una%20enumeraci%C3%B3n%20Colors%2C%20se%20llama,determinados%20valores%20enteros%20son%20valores%20subyacentes%20en%20la%20enumeraci%C3%B3n%20Colors.,-C%23
            /*
                int Numero = 0;
                int Numero2 = 0;
                string strNumero;
                string strNumero2;

                Console.WriteLine("Ingrese un numero por favor: ");
                strNumero = Console.ReadLine();
                if (!Int32.TryParse(strNumero, out Numero))
                {
                    Console.WriteLine("No es un numero valido");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Ingrese otro numero por favor: ");
                strNumero2 = Console.ReadLine();
                if (!Int32.TryParse(strNumero2, out Numero2))
                {
                    Console.WriteLine("No es un numero valido");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine(Numero2 - Numero);
                Console.ReadKey();
            */

            // Ejercicio 3
            // Dados los lados de un triangulo calcular el perímetro.
            // Formula: P = a + b + c
            /*
                string a;
                string b;
                string c;
                int resultado;

                Console.WriteLine("Ingrese Longitud A:");
                a = Console.ReadLine();
                Console.WriteLine("Ingrese Longitud B:");
                b = Console.ReadLine();
                Console.WriteLine("Ingrese Longitud C");
                c = Console.ReadLine();

                int cvrtA = Convert.ToInt32(a);
                int cvrtB = Convert.ToInt32(b);
                int cvrtC = Convert.ToInt32(c);

                resultado = cvrtA + cvrtB + cvrtC;

                Console.WriteLine($"El perímetro es: {resultado}"); ;
                Console.ReadKey();
            */

            // Ejercicio 4
            // Dados los datos necesarios de un Cuadrado calcular la superficie.
            string inputLado;
            int lado;
            int area;

            Console.WriteLine("Ingrese la longitud de un lado del cuadrado:");
            inputLado = Console.ReadLine();

            if (!int.TryParse(inputLado, out lado) || lado <= 0)
            {
                Console.WriteLine("Por favor, ingrese un número válido y positivo.");
                return;
            }

            area = lado * lado;
            Console.WriteLine($"La superficie del cuadrado es: {area}");

            Console.ReadKey();
        }
    }
}
