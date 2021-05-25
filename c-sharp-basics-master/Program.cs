using System;
using c_sharp_basics.Exemplos;

namespace c_sharp_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Pilha();
            var f = new ForExample();

            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            f.contaVezes();
        }
    }
}
