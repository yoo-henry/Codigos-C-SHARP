using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_exemplo_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1° - Declarar a variavel
            string cor;
            //2° - Entrada
            Console.Write("Digite uma cor em inglês:");
            cor = Console.ReadLine().ToUpper();

            switch (cor)
            {
                case "GREEN":
                    Console.Write("A cor digitada em PT-BR é verde");
                    break;
                case "BLUE":
                    Console.Write("A cor digitada em PT-BR é azul");
                    break;
                case "RED":
                    Console.Write("A cor digitada em PT-BR é vermelho");
                    break;
                case "YELLOW":
                    Console.Write("A cor digitada em PT-BR é amarelo");
                    break;
                default:
                    Console.Write("Cor não identificada");
                    break;


            }


        }
    }
}
