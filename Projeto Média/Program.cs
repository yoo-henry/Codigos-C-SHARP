using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Média
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1°Passo - Declarar as variaveis
            string nome_aluno;
            float nota01, nota02, nota03, media;

            //2°Passo - Entrada de dados
            Console.WriteLine("Bem vindo ao Boletim Virtual");

            Console.Write("Digite o nome do aluno: ");
            nome_aluno = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            nota01 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota02 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceita nota: ");
            nota03 = float.Parse(Console.ReadLine());

            media = (nota01 + nota02 + nota03) / 3;







            if (media >= 8)
            {
                Console.WriteLine("Parabéns " + nome_aluno + " você ficou acima da média com " + media + " de média");
            }

            else if (media >= 5 && media <= 7.9)
            {
                Console.WriteLine(nome_aluno + ", você ficou na média com "+ media + " de média");
            }

            
            else if (media >= 3 && media <= 4.9)
            {
                Console.WriteLine(nome_aluno + ", você ficou de recupeção com "+ media + " de média ");
            }

            else
            {
                Console.WriteLine(nome_aluno + " sua média final foi muito ruim, você ficou de recupeção com " + media + " de média");
            }
            
        }
    }
}
