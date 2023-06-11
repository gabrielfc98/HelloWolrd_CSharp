using System;
using System.Threading.Channels;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa utilizado para utilizar a sintaxe básica da Lingaugem C#

            Console.WriteLine("O Console.WriteLine é usado para escrever na tela");
            Console.Write("O Console.Write é usado para imprimir um texto na tela mas sem pular linhas\n");


            //Lendo uma string e imprimindo o resultado na tela

            Console.Write("Digite o seu nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine($"O Console.ReadLine é usado para ler strings.O nome digitado foi: {nome}");

            //Lendo um int e imprimindo o resultado na tela

            Console.Write("Digite a sua idade: ");
            var idade = int.Parse( Console.ReadLine() );
            Console.WriteLine($"Para ler números inteiros é preciso usar a função int.Parse. A idade digitada foi: {idade}");

            //Lendo um double e imprimindo o resultado na tela

            Console.Write("Digite a sua altura: ");
            var altura = double.Parse(Console.ReadLine());
            Console.WriteLine($"Para ler números inteiros é preciso usar a função double.Parse. A idade digitada foi: {altura}");

        }
    }

       


    }

