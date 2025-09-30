using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Dolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1° Passo - Declarar as variaveis
            float contaçao_dolar, quantidade_dolar, total_reais;
            //2° Passo - Reber os valores(Entrada)
            Console.WriteLine("Bem vindo ao conversor do Dolares para Reais");

            Console.Write("Digite a contação atual do dolar: ");
            contaçao_dolar = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantia a ser Convertida: ");
            quantidade_dolar = float.Parse(Console.ReadLine());
            //3° Passo - Processamento
            total_reais = quantidade_dolar * contaçao_dolar;
            //4° Passo - Saída
            Console.WriteLine("O valor convertido é:" + total_reais);

            Console.WriteLine("Aperte a tecla ENTER para sair.");
            Console.ReadKey();
        }
    }
}
