using System;

namespace Certificacao_CSharp_pt1
{
    class PontoFlutuante : IAulaItem
    {
        public void Executar()
        {
            float idade = 15;
            idade = 15.5f;

            //int massa = 6_000000_000000_000000_000000;
            //long massa = 6e24;
            Console.WriteLine($"long.MinValue:{long.MinValue}");
            Console.WriteLine($"long.MaxValue:{long.MaxValue}");

            float massaDaTerra = 5.9736e24f; // System.Single
            Console.WriteLine($"Massa da Terra: {massaDaTerra}");

            float numeroPI = 3.14159f;
            Console.WriteLine($"Número PI: {numeroPI}");

            //float numeroMuitoMaior = 6e100f;
            double numeroMuitoMaior = 6e100;

            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");

            int x = 3;
            int y = 5;

            var resultado = x * y;
            Console.WriteLine($"x * y = {resultado}");
            Console.WriteLine($"O resultado é do tipo: {resultado.GetType()}");

            float z = 4.5f;
            var resultado2 = (x * y) / z;
            Console.WriteLine($"x * y / z = {resultado2}");
            Console.WriteLine($"O resultado é do tipo: {resultado2.GetType()}");
        }
    }
}
