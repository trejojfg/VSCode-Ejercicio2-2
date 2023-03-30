using System;

namespace Ejercicio2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            
            int n1, R;
            Console.WriteLine("Dame un número");
            n1 = int.Parse(Console.ReadLine());
            R = n1 * n1 * n1;
            Console.WriteLine("Tu número elevado al cubo es " + R);
        }
    }
}
