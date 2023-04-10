using System;
using System.Linq;

namespace QuantasVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma palavra ou frase: ");
            string entrada = Console.ReadLine();

            int contagem = entrada.Count(c => "aeiouAEIOU".Contains(c));

            Console.WriteLine("A quantidade de vogais na palavra ou frase é: " + contagem);
            Console.ReadKey();
        }

    }
}
