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

        public static tiempo operator +(tiempo tiempoUno, int valor)
        {
            tiempoUno.cantidad += valor;

            return tiempoUno;
        }

        public static tiempo operator +(tiempo tiempoUno, tiempo tiempoDos)
        {
            tiempoUno.cantidad += tiempoDos.cantidad;

            return tiempoUno;
        }

        public static tiempo operator -(tiempo tiempoUno, int valor)
        {
            tiempoUno.cantidad -= valor;

            return tiempoUno;
        }

        public static tiempo operator -(tiempo tiempoUno, tiempo tiempoDos)
        {
            tiempoUno.cantidad -= tiempoDos.cantidad;

            return tiempoUno;
        }

        public static bool operator ==(tiempo tiempoUno, int valor)
        {
            if (tiempoUno.cantidad == valor)
                return true;
                return false;

        }

        public static bool operator !=(tiempo tiempoUno, int valor)
        {
            
            return !(tiempoUno==valor);

        }

        public static bool operator ==(tiempo tiempoUno, tiempo tiempoDos)
        {
            if (tiempoUno.cantidad == tiempoDos.cantidad)
                return true;
            return false;
        }

        public static bool operator !=(tiempo tiempoUno, tiempo tiempoDos)
        {

            return !(tiempoUno == tiempoDos);

        }

        public static implicit operator tiempo(int numero)
        {
            return new tiempo(numero);

        }

        public static explicit operator tiempo(int numero)
        {
            return new tiempo(numero);

        }
        

    }
}
