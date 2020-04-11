using System;

namespace Certificacao_CSharp_pt1
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade;
            idade = 30;
            Console.WriteLine(idade);

            int copiaIdade = idade;
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Copia Idade: {copiaIdade}");

            idade = 23;
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Copia Idade: {copiaIdade}");

            int? idade2 = null;
            System.Nullable<int> idade3 = null;
        }
    }
}
