
/*
Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo 
para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do 
supermercado em um aplicativo e costuma anotar cada item na mesma hora que 
percebe a falta dele em casa.
O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o 
mesmo item mais de uma vez e a lista acaba ficando extensa. Sua tarefa é 
melhorar o aplicativo de notas desenvolvendo um código que exclua os itens 
duplicados da lista de compras e que os ordene alfabeticamente.
Entrada
A primeira linha de entrada contém um inteiro N (N < 100) com a quantidade de 
casos de teste que vem a seguir, ou melhor, a quantidade de listas de compras 
para organizar. Cada lista de compra consiste de uma única linha que contém de 
1 a 1000 itens ou palavras compostas apenas de letras minúsculas 
(de 1 a 20 letras), sem acentos e separadas por um espaço.
Saída
A saída contém N linhas, cada uma representando uma lista de compra, sem os 
itens repetidos e em ordem alfabética.
Exemplo de Entrada                          Exemplo de Saída
2
carne laranja suco picles laranja picles    carne laranja picles suco
laranja pera laranja pera pera              laranja pera
*/


using System;
using System.Linq;

namespace ComprasSupermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTestes = int.Parse(Console.ReadLine());

            for(int i=0; i < qtdTestes; i++)
            {
                string[] lista = Console.ReadLine().Split().Distinct().OrderBy(p => p).ToArray();
                Console.WriteLine(String.Join(' ', lista));
            }
        }
    }
}




/*
using System;
using System.Collections.Generic;

namespace Pratica02
{
   class Program
   {
      static void Main(string[] args)
      {
         bool temRepetido;
         string itemLista;
         int   indexLista = 0;
         
         int qtdLista = 1;//Convert.ToInt32(Console.ReadLine()); //{"100","200","3","1"};//

         if (qtdLista >= 100)
         {
           qtdLista = 99;
         }
         
         for (int i = 0; i < qtdLista; i++)
         {
            string[] listaCompra = {"suco","carne","frango","carne","chocolate","suco"};//Console.ReadLine().Split(); //{"100","200","3","1"};//
            
            int tamLista = listaCompra.Length;
            List<string> novaLista = new List<string>();

            if (tamLista > 1000)
            {
              tamLista = 1000;
            }


            for (int j = 0; j < tamLista; j++)
            {
               novaLista.Add(listaCompra[j].ToLower());
            }

            novaLista.Sort();
                        
            temRepetido = true;
            itemLista = novaLista[0];
            int totalLista = novaLista.Count;
            int posLista = 1;
            
            while (temRepetido)
            {
               indexLista = -1;

               for (int j = posLista; j < totalLista; j++)
               {
                  if (j >= totalLista)
                  {
                     break;
                  }
                  else
                  {                     
                     if (itemLista == novaLista[j])
                     {                        
                        indexLista = j;
                        break;
                     }
                  }
               }

               if(indexLista >= 0)
               {
                  novaLista.Remove(itemLista);
                  novaLista.Sort();
                  totalLista = novaLista.Count;
               }
               else
               {
                  if (itemLista == novaLista[totalLista-1])
                  {
                     temRepetido = false;
                  }
                  else
                  {                      
                     
                     if (posLista == totalLista)
                     {
                        temRepetido = false;                        
                     }
                     else
                     {
                        itemLista = novaLista[posLista];
                        posLista++;
                     }
                     
                  }
               }
            }
                     
            foreach(string listaAux in novaLista)
            {
               Console.Write(listaAux + " ");
            }

            Console.WriteLine();
            
         }
      }
   }
}
*/