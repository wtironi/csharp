using System;

namespace Bazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++)
            {
                /*PEDRA, PAPEL, TESOURA, LAGARTO e SPOCK
                A TESOURA CORTA O PAPEL;
                O PAPEL EMBRULHA A PEDRA;
                A PEDRA ESMAGA O LAGARTO;
                O LAGARTO ENVENENA SPOCK;
                SPOCK DESTRÓI A TESOURA;
                A TESOURA DECAPITA O LAGARTO;
                O LAGARTO COME O PAPEL;
                O PAPEL CONTESTA SPOCK;
                SPOCK VAPORIZA A PEDRA;
                A PEDRA QUEBRA A TESOURA.
                */
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0].ToUpper();
                v2 = valores[1].ToUpper();
                if( (v1 == "TESOURA" && v2 == "PAPEL"  ) ||
                    (v1 == "PAPEL"   && v2 == "PEDRA"  ) ||
                    (v1 == "PEDRA"   && v2 == "LAGARTO") ||
                    (v1 == "LAGARTO" && v2 == "SPOCK"  ) ||
                    (v1 == "SPOCK"   && v2 == "TESOURA") ||
                    (v1 == "TESOURA" && v2 == "LAGARTO") ||
                    (v1 == "LAGARTO" && v2 == "PAPEL"  ) ||
                    (v1 == "PAPEL"   && v2 == "SPOCK"  ) ||
                    (v1 == "SPOCK"   && v2 == "PEDRA"  ) ||
                    (v1 == "PEDRA"   && v2 == "TESOURA") )
                    Console.WriteLine("Caso #{0}: Bazinga!", i);                
                else if (v1 == v2)   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
        }
    }
}
