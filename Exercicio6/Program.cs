using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Conversão Implícita
            byte numeroPequeno = 50;
            int numeroMedio = Convert.ToInt16(numeroPequeno);/* Converta de byte */
            long numeroGrande = Convert.ToInt32(numeroMedio);/* Converta de int */
            double numeroDecimal = Convert.ToInt64(numeroGrande);/* Converta de int */

            // 2. Conversão Explícita (Cast)
            double pi = 3.14159;
            int piInteiro = Convert.ToInt32(pi);/* Cast para int */
            Console.WriteLine($"{pi}           {piInteiro}");
            int piArredondado;  /* Arredonde e converta */

            // 3. Parse e TryParse
            string texto1 = "42";
            string texto2 = "abc";

            // Parse (pode gerar erro)
            int numero1; /* Parse texto1 */

            // TryParse (seguro)
            bool sucesso; /* TryParse texto2 */

            // 4. ToString
            int idade = 25;
            string idadeTexto; /* Converta para string */
            string idadeFormatada; /* Converta com 3 dígitos (025) */

            // TODO: Exiba todos os resultados
        }
    }
}
