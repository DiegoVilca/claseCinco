using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Enumerados

            eFabricante fabricante;

            fabricante = eFabricante.Honda;

            Console.WriteLine(fabricante);


            fabricante = (eFabricante)1;

            Console.WriteLine(fabricante);

            //----------------------------------------------------------------------

            rueda nuevaRueda;

            nuevaRueda = new rueda();

            //auto nuevoAuto;
            
            /*
            auto autoUno = new auto();
            auto autoDos = new auto();
            auto autoTres = new auto();
             */

            

            carrera nuevaCarrera = new carrera();
            tiempo xTiempo = new tiempo(5);
            kilometro xKilometro = new kilometro(10);

            
            nuevaCarrera.CorrerCarrera(xKilometro);

            nuevaCarrera.CorrerCarrera(xTiempo);

            xTiempo = xTiempo + 10;            
            

            Console.ReadKey();
        }
    }
}
