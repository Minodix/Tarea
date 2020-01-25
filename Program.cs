using System;

namespace SumaDeImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, impar = 0, sumaI = 0;
            Console.WriteLine("Ingrese un numero:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                   // Console.Write("{0},", i);
                    sumaI += i;
                }
            }
            Console.Write("La suma de los numeros impares es: " + sumaI);
            Console.ReadKey();
        }
    }
}
