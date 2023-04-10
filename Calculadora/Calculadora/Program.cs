using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione uma das operações:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Resto da divisão");
            int opcao = int.Parse(Console.ReadLine());

            double resultado = opcao switch
            {
                1 => num1 + num2,
                2 => num1 - num2,
                3 => num1 * num2,
                4 => num1 / num2,
                5 => num1 % num2,
                _ => throw new InvalidOperationException("Opção inválida!")
            };

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}

