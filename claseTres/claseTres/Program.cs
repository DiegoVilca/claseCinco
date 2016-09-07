using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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

            List<auto> listaDeAuto = new List<auto>();
            ArrayList arrayAuto = new ArrayList();
            Stack<auto> pilaAuto = new Stack<auto>();// si recibe el tipo es generica sino es no generica stack
            Queue<auto> colaDeAutos = new Queue<auto>();// si recibe el tipo es generica sino es no generica queue

            pilaAuto.Push(new auto()); //agrega un objeto a la sima de la pila
            pilaAuto.Pop();//remueve y retorna el objeto de arriba de la pila
            //pilaAuto.Peek();//retorna el ultimo elemento pero no lo saca de la pila

            colaDeAutos.Enqueue(new auto()); //agrega un objeto al final de la cola
            colaDeAutos.Dequeue(); //retira un objeto al principio de la cola
            //colaDeAutos.Peek(); //devuelve el objeto al principio de la cola pero no lo retira
            


            arrayAuto.Add("hola"); //se genera una lista no generica, que puede agregar cualquier tipo de dato
            //arrayAuto.Add(new auto());
            arrayAuto.Add("chau");
            listaDeAuto.Add(new auto());// genera una lista generica de tipo auto
            //listaDeAuto.Add("hola");  no anda porque es una lista de auto

            carrera nuevaCarrera = new carrera();
            tiempo xTiempo = new tiempo(5);
            kilometro xKilometro = new kilometro(10);

            
            nuevaCarrera.CorrerCarrera(xKilometro);

            nuevaCarrera.CorrerCarrera(xTiempo);

            //xTiempo = xTiempo + 10;            
            

            Console.ReadKey();
        }
    }
}
