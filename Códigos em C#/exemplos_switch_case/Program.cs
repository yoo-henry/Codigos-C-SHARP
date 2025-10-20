using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplos_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1° - Declarar as variaveis
            int dia_semana;
            //2° - Entradas
            Console.Write("Digite o dia da semana de 1 a 7:");
            dia_semana = int.Parse(Console.ReadLine());
            //3° - Saída
            switch (dia_semana)
            {
                case 1:
                    Console.Write("Hoje é domingo");
                    break;
                case 2:
                    Console.Write("Hoje é segunda - feira ");
                    break;
                case 3:
                    Console.Write("Hoje é terceira - feira");
                    break;
                case 4:
                    Console.Write("Hoje é Quarta - feira");
                    break;
                case 5:
                    Console.Write("Hoje é Quinta - feira");
                    break;
                case 6:
                    Console.Write("Hoje é Sexta - feira");
                    break;
                case 7:
                    Console.Write("Hoje é Sábado");
                    break;
                default:
                    Console.Write("Você deve digitar um número de 1 a 7 !");
                    break;






            }

        }
    }
}
