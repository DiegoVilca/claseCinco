using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class tiempo
    {
        public int cantidad;

        public tiempo(int minutos)
        {
            this.cantidad = minutos;
        }

        public static tiempo operator +(tiempo tiempoAux, int valor)
        {
            tiempoAux.cantidad += valor;
            return tiempoAux;
        }

    }
}
