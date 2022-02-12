namespace Orokles
{
    abstract class MozgoJarmu : Jarmu
    {

        public float IranyX { get; set; }
        public float IranyY { get; set; }

        protected MozgoJarmu(char azonosito, float x, float y, Terkep terkep) : base(azonosito, x, y, terkep)
        {
        }

        public void UjIranyVektor(float iranyX, float iranyY)
        {
            this.IranyX = iranyX;
            this.IranyY = iranyY;
        }

        public abstract void Mozog();
    }
}
