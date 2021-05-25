using System;

namespace Desafio
{
    class minhaClasse 
    {
        static void Main(string[] args) 
        { 

            double valor;
            int inteiro, auxNotas, auxMoedas;
            
            valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"O valor inicial {valor}");
            inteiro = (int)valor;
            valor = (valor - inteiro) * 100;
            auxMoedas = (int)Math.Round(valor);

            Console.WriteLine($"Inteiro {inteiro}");
            Console.WriteLine($"Decimal {auxMoedas}");

            ///*
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{inteiro/100} nota(s) de R$ 100.00");
            auxNotas = (inteiro % 100);
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{auxNotas/50} nota(s) de R$ 50.00");
            auxNotas = (auxNotas % 50);
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{auxNotas/20} nota(s) de R$ 20.00");
            auxNotas = (auxNotas % 20);
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{auxNotas/10} nota(s) de R$ 10.00");
            auxNotas = (auxNotas % 10);
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{auxNotas/5} nota(s) de R$ 5.00");
            auxNotas = (auxNotas % 5);
            
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{auxNotas/2} nota(s) de R$ 2.00");
            auxNotas = (auxNotas % 2);
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{auxNotas/1} moeda(s) de R$ 1.00");
            auxMoedas = (auxMoedas % 100);
            //complete o codigo
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{auxMoedas/50} moeda(s) de R$ 0.50");
            auxMoedas = (auxMoedas % 50);
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{auxMoedas/25} moeda(s) de R$ 0.25");
            auxMoedas = (auxMoedas % 25);
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{auxMoedas/10} moeda(s) de R$ 0.10");
            auxMoedas = (auxMoedas % 10);
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{auxMoedas/5} moeda(s) de R$ 0.05");
            auxMoedas = (auxMoedas % 5);
            
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{auxMoedas/1} moeda(s) de R$ 0.01");
            //auxMoedas = (auxMoedas % 0.01);
            //*/
    
        }
    }
}