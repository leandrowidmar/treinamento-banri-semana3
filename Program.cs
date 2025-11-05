using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            string idadeStr = "25";
            string alturaStr = "1.75";
            string pesoStr = "70.5";
            string nomeStr = "   ";
            string emailStr = "joao@email";

            
            if (int.TryParse(idadeStr, out int idade)&& idade >= 0 && idade <= 150)
            {
                Console.WriteLine($"A idade {idadeStr} é valida");
            }

            if (int.TryParse(alturaStr, out int altura)&& altura >= 0.5 && altura <= 3.0)
            {
                Console.WriteLine($"A altura {altura} é valida");
            }

            if (int.TryParse(pesoStr, out int peso)&& peso >= 2 && peso <= 500)
            {
                Console.WriteLine($"O peso {peso} é valido");
            }

            if (string.IsNullOrWhiteSpace(nomeStr))
            {
                Console.WriteLine($"Nome: Campo obrigatório não preenchido");
            }

            if (emailStr.Contains("@") && emailStr.Contains("."))
            {
                Console.WriteLine($"✓ Email: {emailStr} - Válido");
            }
            // TODO: Valide cada campo:

            // 4. Nome: não pode estar vazio ou só espaços
            // 5. Email: deve conter "@" e "."

            // Use TryParse para conversões seguras
            // Exiba mensagem de sucesso ou erro para cada campo

        }
    }
}