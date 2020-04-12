using System;

namespace Certificacao_CSharp_pt1
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            //objeto = objeto + 3;

            dynamic dinamico = 1;
            dinamico = dinamico + 3;
            Console.WriteLine(dinamico);

            //Verified only on execution time
            //dinamico.teste();
        }
    }
}
