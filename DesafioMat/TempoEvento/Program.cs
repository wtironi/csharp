using System;

namespace TempoEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTermino;
            //continue escrevendo a solucao

            string[] dadosInicio = Console.ReadLine().Split(); //{"dia", "1"};//Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(":");//{"08","00", "00"};//Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);

            string[] dadosTermino = Console.ReadLine().Split();//{"dia", "3"};//Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(":");//{"07","30","15"};//Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
        
            int transformaSegundosInicio = ( segundoMomentoInicio + 
                                             (minutoMomentoInicio * 60)   + 
                                             (horaMomentoInicio   * 3600) + 
                                             (diaInicio           * 86400)//*/
                                            );
            int transformaSegundosTermino = (segundoMomentoTermino + 
                                             (minutoMomentoTermino * 60)   + 
                                             (horaMomentoTermino   * 3600) + 
                                             (diaTermino           * 86400));

            int somaTotalSegundos = ( transformaSegundosTermino - transformaSegundosInicio );

            //Console.WriteLine("Tempo em segundos: {0}", somaTotalSegundos);
            
            int W =  (int)(Math.Truncate(((double)somaTotalSegundos / 86400)));
            Console.WriteLine("{0} dia(s)", W);
            int H =  (int)( Math.Truncate(((double)somaTotalSegundos / 86400 - W)*24));
            Console.WriteLine("{0} hora(s)", H );
            int M =  (int)( Math.Truncate((((((double)somaTotalSegundos / 86400 - W)*24)-H)*60)));
            //(int)(((somaTotalSegundos / 86400)*24)*60);
            Console.WriteLine("{0} minuto(s)", M);
            int S =  (int)( Math.Truncate((((((((double)somaTotalSegundos / 86400 - W)*24)-H)*60)-M)*60)));
            //(int)((((somaTotalSegundos / 86400)*24)*60)*60) ;
            Console.WriteLine("{0} segundo(s)", S);//*/
        }
    }
}
