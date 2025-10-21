using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1°Passo - Declarar as variaveis
            int nascimento, ano_atual, idade;
            //2°Passo - Entrada de dados
            Console.WriteLine("Calculadora de Idade");

            Console.Write("Digite seu ano de nascimento: ");
            nascimento = int.Parse(Console.ReadLine());
           
            Console.Write("Digite o ano atual: ");
            ano_atual = int.Parse(Console.ReadLine());
           
            idade = ano_atual - nascimento;
            //3°Passo - Saída de dados
            Console.WriteLine("A sua idade é: " + idade);

            Console.Write("Aperte a tecla ENTER para fechar");
            Console.ReadKey();
        }
    }
}
