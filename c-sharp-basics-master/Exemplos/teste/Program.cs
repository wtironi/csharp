using System;

namespace Exemplo.teste
{
    class Program
    {
        static void Main(string[ ] args)
        {
            static void Inverter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        
        }
    }
}
