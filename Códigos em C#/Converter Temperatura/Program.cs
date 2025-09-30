using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter_Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1°Passo - Declarar as variaveis
            float temperaturac, temperaturaf;

            //2°Passo - Receber os valores(ENTRADAS)
            Console.WriteLine("Conversor de Temperatura");

            Console.Write("Entre com a Temperatura em C°: ");
            temperaturac = float.Parse(Console.ReadLine());


            //3°Passo - Processamento
            temperaturaf = (9 * temperaturac + 160) / 5;
            //4°Pass - Saída
            Console.Write("A temperatura em Fahrenheit é: " + temperaturaf);








            Console.WriteLine("\n Aperte a tecla ENTER para fechar o programa");
            Console.ReadKey();
        }
    }
}
