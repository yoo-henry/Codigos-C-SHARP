using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classificação_na_natação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Classificação na natação por idade");

            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Ele(a) está no grupo de infantil A.");
            }
            else if (idade >= 8 && idade <= 11)
            {
                Console.WriteLine("Ele(a) está no grupo de infantil B.");
            }
            else if (idade >= 12 && idade <= 13)
            {
                Console.WriteLine("Ele(a) está no grupo de Juvenil A.");
            }
            else if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Ele(a) está no grupo de Juvenil B.");
            }
            else 
            {
                Console.WriteLine("Ele(a) está no grupo de maior de idade.");
            }





            }
    }
}
