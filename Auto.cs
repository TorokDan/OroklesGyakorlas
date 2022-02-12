namespace Orokles
{
    partial class Auto : MozgoJarmu
    {
        public Auto(char azonosito, float x, float y, Terkep terkep) : base(azonosito, x, y, terkep)
        {
        }

        public override void Mozog()
        {
            float sebesseg = 1;
            float afterX = this.X;
            float afterY = this.Y;
            int novekszikX = 0; // 0 marad, 1 növekszik, 2 csökken
            int novekszikY = 0; // 0 marad, 1 növekszik, 2 csökken

            if (this.X < this.IranyX) // Emelkedik X  1
            {
                novekszikX = 1;
                afterX = this.X + 1;
                if (this.Y < this.IranyY) // Emelkedik X Y 1
                {
                    novekszikY = 1;
                    afterY = this.Y + 1;
                }
                if (this.IranyY < this.Y) // Emelkedik X Csökken Y 2
                {
                    novekszikY = 2;
                    afterY = this.Y - 1;
                }
            }
            else if(this.X < this.IranyX) // Csökken X 2
            {
                novekszikX = 2;
                afterX = this.X - 1;
                if (this.Y < this.IranyY) // Csökken X Emelkedik Y 1
                {
                    novekszikY = 1;
                    afterY = this.Y + 1;
                }
                if (this.IranyY < this.Y) // Csökken X Y 2
                {
                    novekszikY = 2;
                    afterY = this.Y - 1;
                }
            }
            if (this.Y < this.IranyY) // Emelkedik Y 1
            {
                novekszikY = 1;
                afterY = this.Y + 1;
                if (this.X < this.IranyX) // Emelkedik Y X 1
                {
                    novekszikX = 1;
                    afterX = this.X + 1;
                }
                if (this.IranyX < this.X) // Emelkedik Y Csökken X 2
                {
                    novekszikX = 2;
                    afterX = this.X - 1;
                }
            }
            else if(this.Y < this.IranyY) // Csökken Y 2
            {
                novekszikY = 2;
                afterY = this.Y - 1;
                if (this.X < this.IranyX) // Csökken Y Emelkedik X 1
                {
                    novekszikX = 1;
                    afterX = this.X + 1;
                }
                if (this.IranyX < this.X) // Csökken Y X 2
                {
                    novekszikX = 2;
                    afterX = this.X - 1;
                }
            }

            float jelenlegiMagassag = this.Terkep.Magassag(this.X, this.Y);
            float kovetkezoMagassag = this.Terkep.Magassag(afterX, afterY);
            sebesseg += jelenlegiMagassag < kovetkezoMagassag ? -0.5f : 0.5f;

            float newX = this.X;
            float newY = this.Y;

            if (novekszikX == 1)
                newX += sebesseg;
            else if (novekszikX == 2)
                newX -= sebesseg;
            else
            {

                if (this.X < this.IranyX)
                    newX += sebesseg;
                else if (this.IranyX < this.X)
                    newX -= sebesseg;
            }

            if (novekszikY == 1)
                newY += sebesseg;
            else if ( novekszikY == 2)
                newY -= sebesseg;
            else
            {
                if (this.Y < this.IranyY)
                    newY += sebesseg;
                else if (this.IranyY < this.Y)
                    newY -= sebesseg;
            }





            //if (this.X < this.IranyX)
            //{
            //    if (this.Y < this.IranyY)
            //        sebesseg = this.Terkep.Magassag(this.X, this.Y) < this.Terkep.Magassag(this.X + 1, this.Y + 1) ? 0.2f : 2f;
            //    if (this.IranyY < this.Y)
            //        sebesseg = this.Terkep.Magassag(this.X, this.Y) < this.Terkep.Magassag(this.X + 1, this.Y - 1) ? 0.2f : 2f;
            //    newX += sebesseg;
            //}
            //else if (this.IranyX < this.X)
            //{
            //    if (this.Y < this.IranyY)
            //        sebesseg = this.Terkep.Magassag(this.X, this.Y) < this.Terkep.Magassag(this.X - 1, this.Y + 1) ? 0.2f : 2f;
            //    if (this.IranyY < this.Y)
            //        sebesseg = this.Terkep.Magassag(this.X, this.Y) < this.Terkep.Magassag(this.X - 1, this.Y - 1) ? 0.2f : 2f;
            //    newX -= sebesseg;
            //}
            //if (this.Y < this.IranyY)
            //{
            //    if (this.X < this.IranyX)
            //        sebesseg = this.Terkep.Magassag(this.X, this.Y) < this.Terkep.Magassag(this.X + 1, this.Y + 1) ? 0.2f : 2f;
            //    if (this.IranyX < this.X)
            //        sebesseg = this.Terkep.Magassag(this.X, this.Y) < this.Terkep.Magassag(this.X - 1, this.Y + 1) ? 0.2f : 2f;
            //    newY += sebesseg;
            //}
            //else if (this.IranyY < this.Y)
            //{
            //    if (this.X < this.IranyX)
            //        sebesseg = this.Terkep.Magassag(this.X, this.Y) < this.Terkep.Magassag(this.X + 1, this.Y - 1) ? 0.2f : 2f;
            //    if (this.IranyX < this.X)
            //        sebesseg = this.Terkep.Magassag(this.X, this.Y) < this.Terkep.Magassag(this.X - 1, this.Y - 1) ? 0.2f : 2f;
            //    newY -= sebesseg;
            //}

            if (this.IdeLephet(newX, newY))
            {
                this.X = newX;
                this.Y = newY;
            }
        }

        public override bool IdeLephet(float x, float y)
        {
            
            if (!this.Terkep.TerkepenBeluliPozicio(x, y) || this.Terkep.Magassag(x, y) < 0)
                return false;
            return true;
        }
    }
}
