using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario();            
           while(opcaoUsuario != "X"){
                switch(opcaoUsuario){
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSeries();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                        //throw new ArgumentOutOfRangeException();
                            
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por usar os nossos serviços.");
            Console.ReadLine();
        }

      private static void VisualizarSerie()
      {
         Console.Write("Informe o indice da série: ");
         int indiceSerie = int.Parse(Console.ReadLine());

         var serie = repositorio.RetornaPorId(indiceSerie);

         Console.WriteLine(serie);
      }

      private static void ExcluirSerie()
      {
         Console.Write("Informe o indice da série: ");
         int indiceSerie = int.Parse(Console.ReadLine());

         repositorio.Exclui(indiceSerie);
      }

      private static void AtualizarSerie()
      {
         
         Console.Write("Informe o indice da série: ");
         int indiceSerie = int.Parse(Console.ReadLine());

         foreach (int i in Enum.GetValues(typeof(Genero)))
         {
            Console.WriteLine("{0}-{1}", i, (string)Enum.GetName(typeof(Genero),  i));
         }

         Console.Write("Digite o genêro entre as opções acima: ");
         int entradaGenero = int.Parse(Console.ReadLine());

         Console.Write("Digite o título da série: ");
         string entradaTitulo = Console.ReadLine();

         Console.Write("Digite o ano de início da série: ");
         int entradaAno = int.Parse(Console.ReadLine());

         Console.Write("Digite a descrição da série: ");
         string entradaDescricao = Console.ReadLine();

         Serie atualizaSerie = new Serie(id: indiceSerie,
                                     genero: (Genero)entradaGenero,
                                     titulo: entradaTitulo,
                                     ano: entradaAno,
                                     descricao: entradaDescricao);
         
         repositorio.Atualiza(indiceSerie, atualizaSerie);
      }

      private static void InserirSeries()
      {
         
         foreach (int i in Enum.GetValues(typeof(Genero)))
         {
            //valor = 
            Console.WriteLine("{0}-{1}", i, (string)Enum.GetName(typeof(Genero),  i));
            //Console.WriteLine("{0}-", i);//, Enum.GetName(typeof(Genero),  i));

         }

         Console.Write("Digite o genêro entre as opções acima: ");
         int entradaGenero = int.Parse(Console.ReadLine());

         Console.Write("Digite o título da série: ");
         string entradaTitulo = Console.ReadLine();

         Console.Write("Digite o ano de início da série: ");
         int entradaAno = int.Parse(Console.ReadLine());

         Console.Write("Digite a descrição da série: ");
         string entradaDescricao = Console.ReadLine();

         Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                     genero: (Genero)entradaGenero,
                                     titulo: entradaTitulo,
                                     ano: entradaAno,
                                     descricao: entradaDescricao);
         
         repositorio.Insere(novaSerie);

      }

      private static void ListarSeries()
      {
         Console.WriteLine("Listar as séries:");
         
         var lista = repositorio.Lista();

         if (lista.Count == 0)
         {
            Console.WriteLine("Nenhuma séries cadastrada.");
            return;
         }

         foreach (var serie in lista)
         {
            var excluido = serie.retornaExcluido();
            Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornoTitulo(), (excluido ? "*Excluido*": "") );
         }
      }

      private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar a tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;
        }
    }
}
