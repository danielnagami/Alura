using System;

namespace Certificacao_CSharp_pt1
{
    public class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdade = idade;

            Console.WriteLine("int idade = 42");
            Console.WriteLine("int copiaIdade = idade");
            Console.WriteLine($"idade = {idade}");
            Console.WriteLine($"copiaIdade = {copiaIdade}");

            idade = 32;

            Console.WriteLine("int idade = 32");
            Console.WriteLine($"idade = {idade}");
            Console.WriteLine($"copiaIdade = {copiaIdade}");


            var cliente1 = new Cliente("José da Silva", 42);
            var cliente2 = cliente1;

            Console.WriteLine(@"var cliente1 = new Cliente(""José da Silva"", 42);");
            Console.WriteLine("var cliente2 = cliente1");
            Console.WriteLine($"cliente1 = {cliente1.ToString()}");
            Console.WriteLine($"cliente2 = {cliente2.ToString()}");

            cliente1.Nome = "Maria de Souza";

            Console.WriteLine(@"cliente1 = ""Maria de Souza""");
            Console.WriteLine($"cliente1 = {cliente1.ToString()}");
            Console.WriteLine($"cliente2 = {cliente2.ToString()}");


        }

        class Cliente
        {
            public Cliente(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }

            public string Nome { get; set; }
            public int Idade { get; set; }
            public override string ToString()
            {
                return $"Nome: {Nome}, Idade: {Idade}";
            }
        }
    }
}
