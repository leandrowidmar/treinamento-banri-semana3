using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 20;
            bool temCNH = true;
            bool temCarro = false;
            double saldo = 150.00;

            if(idade >= 18)
            {
                Console.WriteLine("É maior de idade");
            }

            if (idade >= 18 && temCNH)
            {
                Console.WriteLine("Pode dirigir: Sim");
            }

            if (temCNH && temCarro)
            {
                Console.WriteLine("Pode Viajar de carro próprio: Sim");
            }
            else
            {
                Console.WriteLine("Pode Viajar de carro próprio: NÃO");
            }

            if(saldo >= 100)
            {
            Console.WriteLine("Pode comprar produto (R$ 100): Sim");
            }

            if (idade < 18)
            {
                Console.WriteLine("Situação critica: SIM");
            }
            else
            {
                Console.WriteLine("Situação critica: Não");
            }

            // TODO: Exiba cada verificação com resultado




        }
    }
}
