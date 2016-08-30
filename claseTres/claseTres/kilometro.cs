using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class kilometro
    {
        private int _cantidad;

        public kilometro(int distancia)
        {
            this._cantidad = distancia;
        }

        public static kilometro operator +(kilometro kilometroUno, int valor)
        {
            kilometroUno._cantidad += valor;
            return kilometroUno;
        }

        public static kilometro operator -(kilometro kilometroUno, int valor)
        {
            kilometroUno._cantidad -= valor;
            return kilometroUno;
        }

        public static bool operator ==(kilometro kilometroUno, int valor)
        {
            if (kilometroUno._cantidad == valor)
                return true;
            return false;
        }

        public static bool operator !=(kilometro kilometroUno, int valor)
        {
            return !(kilometroUno == valor);
        
        }

        public static bool operator ==(kilometro kilometroUno, kilometro kilometroDos)
        {
            if (kilometroUno._cantidad == kilometroDos._cantidad)
                return true;
            return false;
        }

        public static bool operator !=(kilometro kilometroUno, kilometro kilometroDos)
        {
            return !(kilometroUno == kilometroDos);
        }

        public static implicit operator kilometro(int numero)
        {
            return new kilometro(numero);

        }

        public static explicit operator kilometro(int numero)
        {
            return new kilometro(numero);
        }


        public static explicit operator int(kilometro Uno)
        {
            return (Uno._cantidad);
        }

    }
}
