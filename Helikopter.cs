using System;

namespace Orokles
{
    class Helikopter : MozgoJarmu
    {
        public float Sebesseg { get; set; }

        public Helikopter(float x, float y, Terkep terkep) : base('H', x, y, terkep)
        {
            this.Sebesseg = 1f;
        }

        public void Gyorsit()
        {
            this.Sebesseg += 0.1f;
        }

        public void Lassit()
        {
            if (0 < this.Sebesseg )
                this.Sebesseg -= 0.1f;
        }

        public override void Mozog()
        {
            ;
            float newX = this.X;
            float newY = this.Y;

            if (this.X < this.IranyX)
                newX += this.Sebesseg;
            else if (this.IranyX < this.X)
                newX -= this.Sebesseg;

            if (this.Y < this.IranyY)
                newY += this.Sebesseg;
            else if (this.IranyY < this.Y)
                newY -= this.Sebesseg;

            if (this.IdeLephet(newX, newY))
            {
                this.X = newX; 
                this.Y = newY;
            }
        }
    }
}
