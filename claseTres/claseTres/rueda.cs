using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class rueda
    {
        public string marca;

        public float tamanio;



        public rueda() //constructor por defecto
        {
            this.marca = "Sin Marca";
        }

        public rueda(string marca)
        {
            this.marca = marca;
        }

        public rueda(int tamanio):this()
        {
            this.tamanio = tamanio;
        }

        public rueda(string marca, int tamanio):this(tamanio)
        {
            this.marca = marca;
        }

        public rueda(int tamanio, string marca):this(marca, tamanio)
        { 
        
        }




        public void MostrarRueda()
        {
            Console.WriteLine("El tamanio es" + this.tamanio);
        }
        
    }
}
