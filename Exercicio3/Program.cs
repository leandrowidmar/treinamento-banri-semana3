using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "  Aprendendo C# é Muito Legal!  ";


            int tamaho = frase.Length;
            Console.WriteLine($" a frase original: {frase} tem {frase.Length} caracteres");
         
            string maiuscula = frase.ToUpper();
            Console.WriteLine($"Maiúscula: {frase.ToUpper()}");

            string minuscula = frase.ToLower();
            Console.WriteLine($"Minuscula: {frase.ToLower()}");

            string semEspaco = frase.Trim();
            Console.WriteLine($"Sem espaços extras: {frase.Trim()}");

            string substituicao = frase.Replace("Legal", "Divertido");
            Console.WriteLine($"Frase substituida: {substituicao}");
         
            string palavra = "C#";
            if (frase.Contains(palavra))
            {
                Console.WriteLine("Contem a palavra C#: Sim");
            }
            else
            {
                Console.WriteLine("Não contem a palavra C#");
            }

            Console.WriteLine(frase.Substring(0,15));
        }
    }
}
