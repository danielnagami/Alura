using System;

namespace Certificacao_CSharp_pt1
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    delegate double MetodoMultiplicacao(double input);

    class Calculadora
    {
        public static void Executar()
        {
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));

            metodoMultiplicacao = Triplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));

            MetodoMultiplicacao metodoQuadrado = delegate (double input)
            {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            Console.WriteLine($"Quadrado: {quadrado}");

            MetodoMultiplicacao metodoCubo = input => input * input * input;
            double cubo = metodoCubo(4.375);
            Console.WriteLine($"Cubo: {cubo}");

        }

        static double Duplicar(double input)
        {
            return input * 2;
        }
        static double Triplicar(double input)
        {
            return input * 3;
        }
    }
}
