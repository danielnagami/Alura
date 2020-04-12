using System;

namespace Certificacao_CSharp_pt1
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);
            Console.WriteLine(retangulo.GetArea());

            Retangulo outroRetangulo = new Retangulo(10, 10);
            Console.WriteLine(retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura));

            outroRetangulo = new Retangulo(5, 6);
            Console.WriteLine(Retangulo.Semelhante(retangulo, outroRetangulo));
        }
    }
    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            Console.WriteLine($"Altura: {altura}, Largura: {largura}");

            var area = GetArea();
            Console.WriteLine($"Área : {area}");
        }

        internal double GetArea()
        { 
            return Altura * Largura;
        }

        internal bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return (
                    (Largura / Altura) ==
                    (outroRetanguloAltura / outroRetanguloLargura)
                    ||
                    (Altura / Largura) ==
                    (outroRetanguloLargura / outroRetanguloAltura)
                   );
        }

        internal static bool Semelhante(Retangulo retangulo, Retangulo outroRetangulo)
        {
            return (
                    (retangulo.Largura / retangulo.Altura) ==
                    (outroRetangulo.Altura / outroRetangulo.Largura)
                    ||
                    (retangulo.Altura / retangulo.Largura) ==
                    (outroRetangulo.Largura / outroRetangulo.Altura)
                   );
        }
    }
}
