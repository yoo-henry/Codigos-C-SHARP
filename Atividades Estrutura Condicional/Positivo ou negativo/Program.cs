using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positivo_ou_negativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Identificador de número positivo ou negativo");

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Seu numero é positivo");
            }
            else
            {
                Console.WriteLine("Seu número é negativo");
            }





        }
    }
}
