using System;
using NachoOperta;

namespace Integrando
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedimos al usuario que ingrese dos números
            Console.WriteLine("Ingrese el primer número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Mostramos los resultados de las operaciones básicas
            Console.WriteLine("Resultados de las operaciones básicas:");
            Console.WriteLine($"Suma: {Class1.Suma(num1, num2)}");
            Console.WriteLine($"Resta: {Class1.Resta(num1, num2)}");
            Console.WriteLine($"Multiplicación: {Class1.Multiplicacion(num1, num2)}");

            // Intentamos realizar la división, pero con manejo de excepción para dividir por 0
            try
            {
                Console.WriteLine($"División: {Class1.Division(num1, num2)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Esperamos a que el usuario presione una tecla para cerrar el programa
            Console.ReadKey();
        }
    }
}
