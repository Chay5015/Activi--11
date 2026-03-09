using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {

        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static void Main()
        {
            int resultado = Sumar(5, 3);
            Console.WriteLine("La suma es: " + resultado);
        }
    }
}
}
