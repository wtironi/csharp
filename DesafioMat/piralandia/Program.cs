using System;

namespace piralandia
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            //continue a solução
            //string[] v = new string[n.Length];
            string v = "";
            //int j = 0;

            for (int i = n.Length; i > 0; i--)
            {
                v += n[i-1].ToString();
                //j++;
            }

            Console.WriteLine(v.ToString());
           
        }
    }
}
