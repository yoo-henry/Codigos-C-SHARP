using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_de_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Identificador de idade");

            Console.Write("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else 
            {
                Console.WriteLine("Você é menor de idade");
            }


            





        }
    }
}
