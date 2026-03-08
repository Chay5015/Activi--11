using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void ImprimirRepetido(string texto, int veces)
        {
            for (int i = 0; i < veces; i++)
            {
                Console.WriteLine(texto);
            }
        }
        static void Main()

        {
            ImprimirRepetido("Heber Chay", 5);
        }
    }
}
