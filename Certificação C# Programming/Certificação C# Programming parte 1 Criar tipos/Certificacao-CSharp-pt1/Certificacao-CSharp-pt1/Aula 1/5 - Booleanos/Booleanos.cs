using System;

namespace Certificacao_CSharp_pt1
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            //bool possuiSaldo = 1;
            bool possuiSaldo = true;

            Console.WriteLine($"possuiSaldo:{possuiSaldo}");

            int dias = DateTime.Now.Day;

            Console.WriteLine($"dias: {dias}");

            bool diasPar = (dias % 2 == 0);

            if (diasPar)
                Console.WriteLine("dias é par");
            else
                Console.WriteLine("dias é ímpar");
        }
    }
}
