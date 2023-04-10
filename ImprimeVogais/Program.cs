using System;

namespace ImprimeVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string input = Console.ReadLine();

            Console.Write("Vogais encontradas: ");

            // Percorre cada caractere da string
            foreach (char c in input)
            {
                // Verifica se o caractere é uma vogal
                if ("aeiouAEIOU".Contains(c))
                {
                    Console.Write(c);
                }
            }

            Console.WriteLine();
        }

    }
}
