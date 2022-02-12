using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Terkep
    {
        int meretX;
        int meretY;
        float[,] magassag;

        public Terkep(int meretX, int meretY)
        {
            this.meretX = meretX;
            this.meretY = meretY;
            magassag = new float[meretX, meretY];
            VeletlenFeltoltes();
        }

        public int MeretX { 
            get { return meretX; } 
        }

        public int MeretY
        {
            get { return meretY; }
        }

        public bool TerkepenBeluliPozicio(float x, float y)
        {
            return x >= 0 && y >= 0 && x < meretX && y < meretY;
        }

        public float Magassag(float x, float y)
        {
            if (x < 0 || y < 0 || x >= meretX || y >= meretY)
                return 2;
            else
                return magassag[(int)x, (int)y];
        }

        private void VeletlenFeltoltes()
        {
            for (int x = 0; x < MeretX; x++)
                for (int y = 0; y < meretY; y++)
                    magassag[x, y] = (float)Math.Min(1.0, 
                        (Math.Sin((float)x / 5) +
                        Math.Cos((float)y / 5) +
                        Math.Cos((float)x / 3) / 2 +
                        Math.Sin((float)y / 3) / 2) / 4 + 0.3);
        }
    }
}
