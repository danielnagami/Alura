using System;

namespace Certificacao_CSharp_pt1
{
    class ParametrosNomeados : IAulaItem
    {
        public void Executar()
        {
            ImprimirDetalhesDoPedido("Maria de Fátima", 31, "Caneca vermelha");

            ImprimirDetalhesDoPedido(numeroPedido: 31, nomeProduto: "Caneca vermelha", vendedor: "Maria de Fátima");

            ImprimirDetalhesDoPedido(nomeProduto: "Caneca vermelha", vendedor: "Maria de Fátima", numeroPedido: 31);

            ImprimirDetalhesDoPedido("Maria de Fátima", 31, nomeProduto: "Caneca vermelha");

            ImprimirDetalhesDoPedido(vendedor: "Maria de Fátima", 31, nomeProduto: "Caneca vermelha");

            ImprimirDetalhesDoPedido("Maria de Fátima", numeroPedido: 31, "Caneca vermelha");
        }

        void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
        {
            if (string.IsNullOrEmpty(vendedor))
                throw new ArgumentException(message: "Nome do vendedor não pode ser nulo ou vazio.");

            Console.WriteLine($"Vendedor: {vendedor}, Pedido nº{numeroPedido}, Produto: {nomeProduto}");
        }
    }
}
