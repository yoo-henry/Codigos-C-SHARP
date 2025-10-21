using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 Passo - Declarar as variaveis
            float numero1, numero2, total;
            string nome;

            Console.WriteLine("Projeto Soma");

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = float.Parse(Console.ReadLine());
                
            Console.WriteLine("Digite o segundo número:");
            numero2 = float.Parse(Console.ReadLine());
            //2° Etapa - Processamento

            total = numero1 + numero2;

            //3° Etapa - Saída
            Console.WriteLine("Olá " + nome + "," +
                "o resultado é: " + total);

            Console.WriteLine("Pressione <ENTER> para continuar.");
            Console.ReadKey();

        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              