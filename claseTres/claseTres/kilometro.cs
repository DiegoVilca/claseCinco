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
            kilometroUno.cantidad -= valor;
            return kilometroUno;
        }

        public static bool operator ==(kilometro kilometroUno, int valor)
        {
            if (kilometroUno.cantidad == valor)
                return true;
            return false;
        }

        public static bool operator !=(kilometro kilometroUno, int valor)
        {
            return !(kilometroUno == valor);
        
        }

        public static bool operator ==(kilometro kilometroUno, kilometro kilometroDos)
        {
            if (kilometroUno.cantidad == kilometroDos.cantidad)
                return true;
            return false;
        }

        public static bool operator !=(kilometro kilometroUno, kilometro kilometroDos)
        {
            return !(kilometroUno == kilometroDos);
        }

    }
}
