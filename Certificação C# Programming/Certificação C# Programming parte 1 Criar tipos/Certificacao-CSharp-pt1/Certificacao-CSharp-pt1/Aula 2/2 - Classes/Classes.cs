using System;

namespace Certificacao_CSharp_pt1
{
    class Classes : IAulaItem
    {
        public void Executar()
        {
            ClassePosicaoGPS posicao1 = new ClassePosicaoGPS() 
            {
                Latitude = 13.78,
                Longitude = 29.51
            };

            posicao1 = new ClassePosicaoGPS(13.78, 29.51);
            Console.WriteLine(posicao1.ToString());

            PosicaoGPSComLeitura posicao2 = new PosicaoGPSComLeitura(13.78, 29.51, DateTime.Now);
            Console.WriteLine(posicao2.ToString());

        }

        public class ClassePosicaoGPS : IGPS
        {
            public double Latitude;
            public double Longitude;

            public ClassePosicaoGPS(){}

            public ClassePosicaoGPS(double latitude, double longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }

            public bool EstaNoHemisferioNorte()
            {
                return Latitude > 0;
            }

            public override string ToString()
            {
                return $"Latitude: {Latitude}, Longitude: {Longitude}";
            }
        }
        public class PosicaoGPSComLeitura : ClassePosicaoGPS
        {
            private readonly DateTime dataLeitura;

            public PosicaoGPSComLeitura(double latitude, double longitude, DateTime dataLeitura) : base(latitude, longitude)
            {
                this.dataLeitura = dataLeitura;
            }
            public override string ToString()
            {
                return $"Latitude: {Latitude}, Longitude: {Longitude}, Data Leitura: {dataLeitura}";
            }
        }
    }
}
