using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Produto 1
            string nomeProduto1 = "Mouse Gamer";
            decimal precoProduto1 = 89.90m;
            int quantidadeProduto1 = 2;

            // TODO: Crie variáveis para mais 2 produtos
            string nomeProduto2 = "Teclado Mecânico";
            decimal precoProduto2 = 250.00m;
            int quantidadeProduto2 = 1;

            string nomeProduto3 = "Mousepad";
            decimal precoProduto3 = 30.50m;
            int quantidadeProduto3 = 1;

            // TODO: Calcule:

            // - Subtotal de cada produto
            decimal totalMouse = precoProduto1 * quantidadeProduto1;
            decimal totalTeclado = precoProduto2 * quantidadeProduto2;
            decimal totalMousePad = precoProduto3 * quantidadeProduto3;

            // - Total da compra
            decimal totalCompra = totalMouse + totalTeclado + totalMousePad;
            
            // - Desconto de 10% se total > 200
            int porcentagem = 10;
            decimal descontoValor = totalCompra * porcentagem / 100;

            // - Total final
            decimal ValorTotalComDesconto = totalCompra - descontoValor;

            // TODO: Exiba um recibo formatado
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("                         RECIBO                               ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("     ITEM             QTD             PREÇO           SUBTOTAL");
            Console.WriteLine($"{nomeProduto1}            {quantidadeProduto1}              {precoProduto1}            {totalMouse}");
            Console.WriteLine($"{nomeProduto2}       {quantidadeProduto2}             {precoProduto2}            {totalTeclado}");
            Console.WriteLine($"{nomeProduto3}               {quantidadeProduto3}              {precoProduto3}            {totalMousePad}");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"                                  Subtotal:  R$ {totalCompra}");
            Console.WriteLine($"                                  Desconto:  R$ {descontoValor}");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"                                  TOTAL A PAGAR: R$ {ValorTotalComDesconto}");
            Console.WriteLine("--------------------------------------------------------------");





        }
    }
}
