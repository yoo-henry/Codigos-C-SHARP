using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;

            Console.WriteLine("Calculadora de IMC");

            Console.Write("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc <= 16.9)
            {
                Console.WriteLine("Muito abaixo do peso");
            }
            else if (imc <= 18.4)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Acima do peso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (imc <= 40)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Obesidade Grau III");
            }





        }
    }
}
