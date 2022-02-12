namespace Orokles
{
    class Szimulacio : TerkepEsJamuRajzolo
    {
        public Szimulacio(Terkep terkep, int tombMeret) : base(terkep, tombMeret)
        {
        }

        public void EgyIdoEgysegEltelt()
        {
            for (int i = 0; i < this.JarmuvekN; i++)
                if (this.Jarmuvek[i] is MozgoJarmu)
                    (this.Jarmuvek[i] as MozgoJarmu).Mozog();
        }

        public void Fut()
        {
            while (true)
            {
                EgyIdoEgysegEltelt();
                this.Kirajzol();
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
