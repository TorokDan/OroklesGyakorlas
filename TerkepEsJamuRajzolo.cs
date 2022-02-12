using System;

namespace Orokles
{
    class TerkepEsJamuRajzolo : TerkepRajzolo
    {
        public Jarmu[] Jarmuvek { get; set; }
        public int JarmuvekN { get; set; }

        public TerkepEsJamuRajzolo(Terkep terkep, int tombMeret)
            :base(terkep)
        {
            Jarmuvek = new Jarmu[tombMeret];
            JarmuvekN = 0;
        }

        public void JarmuFelvetel(Jarmu jarmu)
        {
            Jarmuvek[JarmuvekN++] = jarmu;
        }

         protected override char MiVanItt(int x, int y)
        {
            for (int i = 0; i < JarmuvekN; i++)
                if (Convert.ToInt32(Jarmuvek[i].X) == x && Convert.ToInt32(Jarmuvek[i].Y) == y)
                    return Jarmuvek[i].Azonosito;
            return base.MiVanItt(x, y);
        }
    }
}
