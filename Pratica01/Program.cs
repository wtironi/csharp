using System;

namespace Pratica01
{
   class Program
   {
      static void Main(string[] args)
      {
         
         string[] entrada = Console.ReadLine().Split(); //{"1.0","-5.0"};//
         
         //Console.Write("Informe com o valor de X: ");
         double x = Math.Round(Convert.ToDouble(entrada[0]), 1);
         Console.Write(" ");
         //Console.Write("Informe com o valor de Y: ");
         double y =  Math.Round(Convert.ToDouble(entrada[1]), 1);
         //Console.WriteLine("Hello World!");

         if ( x== 0 && y==0)
         {            
            Console.WriteLine("Origem");
         }
         else if (x == 0 && y!=0)
         {
             Console.WriteLine("Eixo Y");
         }
         else if (x != 0 && y ==0)
         {
             Console.WriteLine("Eixo X");
         }
         else if (x > 0 && y > 0)
         {
             Console.WriteLine("Q1");
         }
         else if (x < 0 && y > 0)
         {
             Console.WriteLine("Q2");
         }
         else if (x < 0 && y < 0)
         {
             Console.WriteLine("Q3");
         }
         else if (x > 0 && y < 0)
         {
             Console.WriteLine("Q4");
         }

      }
   }
}
