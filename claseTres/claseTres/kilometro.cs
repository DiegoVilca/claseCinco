using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class kilometro
    {
        public int cantidad;

        public kilometro(int distancia)
        {
            this.cantidad = distancia;
        }

        public static kilometro operator +(kilometro kilometroUno, int valor)
        {
            kilometroUno.cantidad += valor;
            return kilometroUno;
        }

        public static kilometro operator -(kilometro kilometroUno, int valor)
        {
            kilometroUno.cantidad += valor;
            return kilometroUno;
        }
    }
}
