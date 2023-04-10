using System;
using System.Linq;

namespace ImprimeConsoantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string input = Console.ReadLine().ToLower(); // lê a entrada do usuário e converte para minúsculas
            string consonants = new string(input.Where(c => !"aeiou ".Contains(c)).ToArray());

            Console.WriteLine("Consoantes encontradas: " + consonants);
            Console.ReadKey();
        }

    }
}
