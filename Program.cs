using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orokles
{
    class Program
    {
        static void Teszt1()
        {
            Terkep terkep = new Terkep(80, 25);
            Szimulacio szimulacio = new Szimulacio(terkep, 5);

            Helikopter helikopter = new Helikopter(10, 10, terkep);
            Helikopter helikopter2 = new Helikopter(10, 5, terkep);

            Auto auto = new Auto('A', 10, 5, terkep);

            Tank tank = new Tank('T', 100, 15, 8, terkep);
            
            helikopter.UjIranyVektor(1, 16);
            helikopter2.UjIranyVektor(15, 30);
            auto.UjIranyVektor(50, 3);
            
            szimulacio.JarmuFelvetel(helikopter);
            szimulacio.JarmuFelvetel(helikopter2);

            szimulacio.JarmuFelvetel(auto);

            szimulacio.JarmuFelvetel(tank);


            szimulacio.Fut();
        }

        static void Main(string[] args)
        {
            Teszt1();
            ;
        }
    }
}
