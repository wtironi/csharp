using System;
using System.Collections.Generic;

namespace Dio.Bank
{
    class Program
    {
        static List<Conta> listConta = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = OpcaoUsuario();

            while(opcaoUsuario != "X"){
                switch(opcaoUsuario){
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        SacarConta();
                        break;
                    case "5":
                        DepositarConta();
                        break;
                    case "C":
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                            
                }

                opcaoUsuario = OpcaoUsuario();
            }

            Console.WriteLine("Obrigado por usar os nossos serviços.");
            Console.ReadLine();

        }

      private static void Transferir()
      {
         Console.Write("Digite o numero da conta destino: ");
         int indiceContaOrigem = int.Parse(Console.ReadLine());

         Console.Write("Digite o numero da conta destino: ");
         int indiceContaDestino = int.Parse(Console.ReadLine());

         Console.Write("Digite o valor a ser transferido: ");
         double valorTransferencia = double.Parse(Console.ReadLine());

         listConta[indiceContaOrigem].Transferir(valorTransferencia, listConta[indiceContaDestino]);
      }

      private static void DepositarConta()
      {
         Console.Write("Digite o numero da conta: ");
         int indiceConta = int.Parse(Console.ReadLine());

         Console.Write("Digite o valor a ser depositado: ");
         double valorDeposito = double.Parse(Console.ReadLine());

         listConta[indiceConta].Depositar(valorDeposito);
      }

      private static void SacarConta()
      {
         Console.Write("Digite o numero da conta: ");
         int indiceConta = int.Parse(Console.ReadLine());

         Console.Write("Digite o valor a ser sacado: ");
         double valorSaque = double.Parse(Console.ReadLine());

         listConta[indiceConta].Sacar(valorSaque);

      }

      private static void ListarContas()
      {
         if (listConta.Count == 0)
         {
            Console.WriteLine("Nenhuma conta cadastada.");
            return;             
         }

         for (int i = 0; i < listConta.Count; i++)
         {
            Conta conta = listConta[i];
            Console.Write("#{0} - ", i); 
            Console.WriteLine(conta);
         }
      }

      private static void InserirConta()
      {
         Console.WriteLine("Inserir nova conta");

         Console.Write("Digite 1 para conta Física ou 2 para conta jurídica: ");
         int entradaTipoConta = int.Parse(Console.ReadLine());

         Console.Write("Digite o nome do cliente: ");
         string entradaNome = Console.ReadLine();

         Console.Write("Digite o saldo inicial: ");
         double entradaSaldo = double.Parse(Console.ReadLine());

         Console.Write("Digite o crédito disponível: ");
         double entradaCredito = double.Parse(Console.ReadLine());

         Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                     saldo: entradaSaldo,
                                     credito: entradaCredito,
                                     nome: entradaNome);
        
        listConta.Add(novaConta);

      }

      private static string OpcaoUsuario(){
            Console.WriteLine("");
            Console.WriteLine("DIO Bank a seu dispor!");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar as contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar a tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;


        }
    }
}
