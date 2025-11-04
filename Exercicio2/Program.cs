using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Conversor de temperatura-----");           
            double celsius = 25.0;

            // TODO: Implemente as conversões
            double fahrenheit = ((celsius * 9 / 5) + 32);
            double kelvin = celsius + 273.15 ;

            // TODO: Exiba os resultados formatados
            Console.WriteLine($"TEMPERATURA EM CELSIUS: {celsius:f2}°C");
            Console.WriteLine($"TEMPERATURA EM FAHRENHEIT: {fahrenheit:f2}F");
            Console.WriteLine($"TEMPERATURA EM KELVIN: {kelvin:f2}K");

        }
    }
}
