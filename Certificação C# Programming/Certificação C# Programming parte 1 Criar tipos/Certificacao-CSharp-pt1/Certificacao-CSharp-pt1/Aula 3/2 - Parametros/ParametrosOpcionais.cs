using System;

namespace Certificacao_CSharp_pt1
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas Skywalker");
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial.FazerPedido(2, "Comercial");

            clienteEspecial.FazerPedido(3);

            clienteEspecial.FazerPedido(3, quantidade:4);
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "Anônimo")
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId, string endereco = "Residencial", int quantidade = 10)
        {
            Console.WriteLine($"Cliente: {nome}, ProdutoId: {produtoId}, Endereço: {endereco}, Quantidade: {quantidade}");
        }
    }
}
