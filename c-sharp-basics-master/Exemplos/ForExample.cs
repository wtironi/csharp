using System;

namespace c_sharp_basics.Exemplos
{
        class ForExample
    {
            public void contaVezes()
            {
                int [] numeroDeVezes = {1, 2, 4, 5};
                for (int i = 0; i < numeroDeVezes.Length; i++) Console.WriteLine($"Bem-vindo ao curso de .NET: {i}");
            }
    }
}

