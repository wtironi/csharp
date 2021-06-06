using System; 

namespace DesafioMat
{
    class minhaClasse {

        static void Main(string[] args) { 

            int t = Convert.ToInt32(Console.ReadLine()); //1;//
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split(); //{"100","200","3","1"};//
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

            //declare as variaveis corretamente
                cpa = double.Parse(valores[2]);
                cpb = double.Parse(valores[3]);

                cpa = (cpa/100);
                cpb = (cpb/100);

                while (pa <= pb && anos <= 100)
                {
                
                    pa += (int) Math.Floor( (cpa/100) * pa);
                    pb += (int) Math.Floor( (cpb/100) * pb);
                    anos++;

                //complete o while

                    if (anos > 100)
                    {
                        //complete a condicional
                        Console.WriteLine("Mais de 1 seculo.");
                        //break;
                    }
                }

                if (anos <= 100)
                {
                //complete a condicional
                    Console.WriteLine("{0} anos.", anos);
                    //break;
                }

            }

        }
    }
}