using System;

namespace Certificacao_CSharp_pt1
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = 'S'; // System.Char
            //1 número com 2 bytes

            byte nivelDeAzul = 0xFF; // = 255 decimal
            //de 0 a 255
            //nivelDeAzul = -3; //não permite negativos

            short passageirosVoo = 230; //System.Int16
            passageirosVoo = -7;
            //permite negativos
            //inteiro com 2 bytes, tem 16 bits

            int populacao = 1500; // System.Int32
            populacao = -2300;

            long populacaoDoBrasil = 207_660_929; // */- 207 milhões - System.Int64

            sbyte nivelDeBrilho = -127; // SYstem.Sbyte

            ushort passageirosNavio = 230; // System.UInt16
            // não permite sinais porém em troca libera mais um bit para armazenar um número

            uint estoque = 1500; // System.UInt32

            ulong populacaoDoMundo = 7_000_000_000; // System.UInt64

            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"resposta: {resposta}");
            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");
            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");
        }
    }
}
