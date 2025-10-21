using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maior_Número
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"O primeiro número é o maior. Sendo {num1}");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"O segundo número é o maior. Sendo {num2} ");
            }

            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine($"O terceiro número é o maior. Sendo {num3} ");
            }
            else
            {
                Console.WriteLine("O maior número são iguais");
            }




        }
    }
}
