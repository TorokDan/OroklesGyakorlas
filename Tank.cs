namespace Orokles
{
    sealed class Tank : Auto
    {
        public int Uzemanyag { get; set; }
        public Tank(char azonosito, int uzemanyag, float x, float y, Terkep terkep) : base(azonosito, x, y, terkep)
        {
            Uzemanyag = uzemanyag;
        }
        public override void Mozog()
        {
            if (Uzemanyag > 0)
            {
                this.X = this.X + 1f;
                this.Y = this.Y + 1f;
                this.Uzemanyag = this.Uzemanyag >= 10 ? Uzemanyag - 10: 0;
            }
        }

        public override bool IdeLephet(float x, float y)
        {
            return true; ;
        }
    }
}
