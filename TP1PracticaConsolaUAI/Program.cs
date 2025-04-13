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
            /*
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
            */

            // Ejercicio 5
            // Dados los datos necesarios de un Rectángulo calcular la superficie.
            /*
                string inputBase, inputAltura;
                int baseRectangulo, altura, area;

                Console.WriteLine("Ingrese la base del rectángulo:");
                inputBase = Console.ReadLine();

                Console.WriteLine("Ingrese la altura del rectángulo:");
                inputAltura = Console.ReadLine();

                if (!int.TryParse(inputBase, out baseRectangulo) || baseRectangulo <= 0)
                {
                    Console.WriteLine("La base debe ser un número válido y positivo.");
                    return;
                }

                if (!int.TryParse(inputAltura, out altura) || altura <= 0)
                {
                    Console.WriteLine("La altura debe ser un número válido y positivo.");
                    return;
                }

                area = baseRectangulo * altura;
                Console.WriteLine($"La superficie del rectángulo es: {area}");

                Console.ReadKey();
            */

            // Ejercicio 6: Calcular el diámetro a partir de la circunferencia
            /*
                string inputCircunferencia;
                double circunferencia, diametro;

                Console.WriteLine("Ingrese la circunferencia del círculo:");
                inputCircunferencia = Console.ReadLine();

                if (!double.TryParse(inputCircunferencia, out circunferencia) || circunferencia <= 0)
                {
                    Console.WriteLine("Por favor, ingrese un valor válido y positivo para la circunferencia.");
                    return;
                }

                diametro = circunferencia / Math.PI;
                Console.WriteLine($"El diámetro del círculo es: {diametro:F2}"); // F2 para mostrar con 2 decimales

                Console.ReadKey();
            */
            // Ejercicio 7
            // Si 1Byte tiene 8 bits, desarrolle una solución programática que permita calcular cuántos bits hay en
            // cualquier combinación de x KBytes. Explique cómo llegó a esa conclusión.
            /*
                const int BITS_POR_BYTE = 8;
                const int BYTES_POR_KB = 1024;
                int kilobytes;
                int totalBits;

                Console.WriteLine("Ingrese Cantidad de Byte para calcular los bits:");
                kilobytes = Convert.ToInt32(Console.ReadLine());
                totalBits = kilobytes * BYTES_POR_KB * BITS_POR_BYTE;
                Console.WriteLine($"El equivalente en bits son: {totalBits}");
                Console.ReadKey();
            */

            // Ejercicio 8
            // Calcular el factorial de 6.
            /*
                int numero = 6;
                int factorial = 1;

                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"El factorial de {numero} es: {factorial}");
                Console.ReadKey();
            */

            // Ejercicio 9
            // Dadas dos frases concatenarlas y mostrar el resultado. 
            /*
                string frase1, frase2, resultado;

                Console.WriteLine("Ingrese la primera frase:");
                frase1 = Console.ReadLine();

                Console.WriteLine("Ingrese la segunda frase:");
                frase2 = Console.ReadLine();

                // Concatenación
                resultado = frase1 + " " + frase2;

                Console.WriteLine($"La frase resultante es: {resultado}");

                Console.ReadKey();
            */
            // Ejercicio 10: Reorganizar frase con substring
            /*
                string x;
                string primeraMitad, segundaMitad, resultado;

                Console.WriteLine("Ingrese una frase:");
                x = Console.ReadLine();

                int longitud = x.Length;
                int mitad = longitud / 2;

                // Si la longitud es impar, la segunda mitad incluirá un carácter más
                segundaMitad = x.Substring(mitad);
                primeraMitad = x.Substring(0, mitad);

                resultado = segundaMitad + primeraMitad;

                Console.WriteLine($"Frase reorganizada: {resultado}");

                Console.ReadKey();
            */

            // Ejercicio 11: Dada una frase informar la cantidad de caracteres que tiene.
            /*
                string frase;
                int cantidadCaracteres;

                Console.WriteLine("Ingrese una frase:");
                frase = Console.ReadLine();

                cantidadCaracteres = frase.Length;

                Console.WriteLine($"La frase tiene {cantidadCaracteres} caracteres.");

                Console.ReadKey();
            */

            // Ejercicio 12
            // Mostrar la fecha y hora actual.
            /*
                DateTime ahora = DateTime.Now;

                Console.WriteLine("Fecha y hora actual:");
                Console.WriteLine(ahora);
                Console.ReadKey();
            */

            // Ejercicio 13
            /*
                Console.WriteLine("Ingrese una fecha (por ejemplo: 13/04/2025):");
                string input = Console.ReadLine();

                DateTime fecha;

                if (DateTime.TryParse(input, out fecha))
                {
                    string formato = fecha.ToString("yyyyMMdd");
                    Console.WriteLine($"La fecha en formato AAAAMMDD es: {formato}");
                }
                else
                {
                    Console.WriteLine("La fecha ingresada no es válida.");
                }

                Console.ReadKey();
            */

            // Ejercicio 14
            // Dadas dos fechas calcular la diferencia en días entre una y la otra.
            /*
                Console.WriteLine("Ingrese la primera fecha (formato: dd/mm/aaaa):");
                string input1 = Console.ReadLine();

                Console.WriteLine("Ingrese la segunda fecha (formato: dd/mm/aaaa):");
                string input2 = Console.ReadLine();

                DateTime fecha1, fecha2;

                if (DateTime.TryParse(input1, out fecha1) && DateTime.TryParse(input2, out fecha2))
                {
                    TimeSpan diferencia = fecha2 - fecha1;
                    Console.WriteLine($"La diferencia entre las dos fechas es de {Math.Abs(diferencia.Days)} días.");
                }
                else
                {
                    Console.WriteLine("Una o ambas fechas ingresadas no son válidas.");
                }

                Console.ReadKey();
            */
            // Ejercicio 15
            // Informar cuantos días faltan para el 25 / 12 / 2020.
            DateTime fechaObjetivo = new DateTime(2020, 12, 25);
            DateTime hoy = DateTime.Today;

            TimeSpan diferencia = fechaObjetivo - hoy;

            if (diferencia.TotalDays > 0)
            {
                Console.WriteLine($"Faltan {diferencia.Days} días para el 25/12/2020.");
            }
            else if (diferencia.TotalDays == 0)
            {
                Console.WriteLine("¡Hoy es 25/12/2020!");
            }
            else
            {
                Console.WriteLine($"El 25/12/2020 ya pasó hace {-diferencia.Days} días.");
            }

            Console.ReadKey();

        }
    }
}
