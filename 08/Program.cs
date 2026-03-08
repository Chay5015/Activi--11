using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{
    internal class Program
    {
        static void MostrarElCuadrado(int n)
        {
            int cuadrado = (int)Math.Pow(n, 2);
            Console.WriteLine("El cuadrado del numero es " + cuadrado);
        }
        static void Main()
        {
            MostrarElCuadrado(4);
        }
    }
}
