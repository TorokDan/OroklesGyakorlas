namespace Orokles
{
    class Jarmu
    {
        public char Azonosito { get; protected set; }
        public float X { get; protected set; }
        public float Y { get; protected set; }
        public Terkep Terkep { get; set; }

        public Jarmu(char azonosito, float x, float y, Terkep terkep)
        {
            this.Azonosito = azonosito;
            this.X = x;
            this.Y = y;
            this.Terkep = terkep;
        }

        public virtual bool IdeLephet(float x, float y)
        {
            return this.Terkep.TerkepenBeluliPozicio(x, y);
        }
    }
}
