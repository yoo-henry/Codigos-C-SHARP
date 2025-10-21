using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace calculadora_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, total;
            int sinal;

            Console.WriteLine("Digite 1 para somar, 2 para subtrair, 3 para multiplicar, 4 para dividir: ");
            sinal = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero para calcular: ");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Digite outro numero para calcular: ");
            num2 = float.Parse(Console.ReadLine());




            switch (sinal)
            {
                case 1:
                    total = num1 + num2;
                    Console.Write($"O resultado da sua soma é: {total}");
                    break;
                case 2:
                    total = num1 - num2;
                    Console.Write($"O resultado da sua subtração é: {total}");
                    break;
                case 3:
                    total = num1 * num2;
                    Console.Write($"O resultado da sua multiplicação é: {total}");
                    break;
                case 4:
                    total = num1 / num2;
                    Console.Write($"O resultado da sua divisão é: {total} ");
                    break;
                default:
                    Console.Write("Você deve digitar 1 para somar, 2 para subtrair, 3 para multiplicar, 4 para dividir");
                    break;
            }
        }
    }
}
