using System;

namespace Certificacao_CSharp_pt1
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Este é\r\no meu documento");
            impressora.ImprimirDocumento();
            ImprimirDocumentoHTML(impressora.Documento);
            impressora.ImprimirDocumentoHTML();

        }
        void ImprimirDocumentoHTML(string documento)
        {
            Console.WriteLine($"<html><body>{documento}</body></html>");
        }
    }

    internal class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }

        //public void ImprimirDocumentoHTML()
        //{
        //    Console.WriteLine($"<html><body>{Documento}</body></html>");
        //}
    }

    static class ImpressoraExtensions
    {
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    }
}
