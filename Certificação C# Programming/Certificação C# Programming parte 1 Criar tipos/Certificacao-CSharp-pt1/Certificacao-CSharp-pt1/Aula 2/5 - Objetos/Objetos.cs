using System;

namespace Certificacao_CSharp_pt1
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
            int pontuacao = 10;
            Console.WriteLine($"Pontuação: {pontuacao}");

            Console.WriteLine("Objeto com valor primitivo");
            object meuObjeto;
            meuObjeto = pontuacao;
            Console.WriteLine($"Valor meuObjeto: {meuObjeto}");
            Console.WriteLine($"Tipo do meuObjeto: {meuObjeto.GetType()}");


            Console.WriteLine();
            Console.WriteLine("Object com referência de objeto");

            meuObjeto = new Jogador();
            Jogador classRef;
            classRef = (Jogador)meuObjeto;

            Console.WriteLine($"classRef pontuação: {classRef.Pontuacao}");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }

}
