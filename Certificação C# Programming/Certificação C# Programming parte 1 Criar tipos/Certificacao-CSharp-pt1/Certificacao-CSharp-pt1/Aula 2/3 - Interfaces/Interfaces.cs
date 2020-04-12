namespace Certificacao_CSharp_pt1
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligar();

            eletro1 = new Abajour();
            eletro1.Ligar();
        }
    }

    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }
    }

    class Televisao : IEletrodomestico
    {
        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }

    class Abajour : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }
        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }
        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }

    class Radio : IEletrodomestico
    {
        public void Desligar()
        {

        }
        public void Ligar()
        {

        }
    }
}
