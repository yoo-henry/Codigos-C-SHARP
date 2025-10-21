using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento_dos_professores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int salario,nivel,quantidade_aulas;

            Console.WriteLine("Pagamento dos professores");

            Console.Write("Qual é o seu nivel de professor ? (1),(2) ou (3): ");
            nivel = int.Parse(Console.ReadLine());

            Console.Write("Quantos dias da semana você deu aula? ");
            quantidade_aulas= int.Parse(Console.ReadLine());

            if (nivel == 1)
            {
                salario = 12 * quantidade_aulas;
                Console.WriteLine($"Você é professor de nível 1, e você deu {quantidade_aulas} nessa semana, então seu salário semanal é de R${salario}. ");
            }
            else if (nivel == 2)
            {
                salario = 17 * quantidade_aulas;
                Console.WriteLine($"Você é professor de nível 1, e você deu {quantidade_aulas} nessa semana, então seu salário semanal é de R${salario}. ");
            }
            else if (nivel == 3) 
            {
                salario = 25 * quantidade_aulas;
                Console.WriteLine($"Você é professor de nível 1, e você deu {quantidade_aulas} nessa semana, então seu salário semanal é de R${salario}. ");
            }





        }
    }
}
