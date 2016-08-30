using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class auto
    {

        private eFabricante fabricante;

        public rueda di;
        public rueda dd;
        public rueda ti;
        public rueda td;
        public static int contadorDeObjetos;
        private int kilometrosRecorridos;
        private int tiempoDemorado;
        private static Random numeroRandom;




        // constructor de instancia
        public auto() 
        {

            //this.fabricante = "Sin fabricante";

            this.di = new rueda();
            this.dd = new rueda();
            this.ti = new rueda();
            this.td = new rueda();

            //Random random = new Random();  reemplazo a "random" por "numeroRandom" que se instancia
            //una vez por todos los autos creados dentro del constructor estatico
            this.fabricante = (eFabricante)numeroRandom.Next(0, 2);



            auto.contadorDeObjetos++;
        }

        //constructor estatico
        //no acepta modificadores de visibilidad
        static auto()   
        { 
            //atributos estaticos
            auto.contadorDeObjetos = 0;

            auto.numeroRandom = new Random();

            
        }

        public static bool CompararAuto(auto auto1, auto auto2)
        {
            if (auto1.fabricante == auto2.fabricante)
                return true;
                return false;
        }


        public void MostrarAuto()
        {
            Console.WriteLine("El fabricante es: " + this.fabricante);
        }


        public void VolverACero()
        {
            this.kilometrosRecorridos = 0;
            this.tiempoDemorado = 0;
        }

        public void AgregarKilometro(int kilometros)
        {
            this.kilometrosRecorridos += kilometros;
        }

        public int DevolverKilometro()
        {
            return this.kilometrosRecorridos;
        }

        public void AgregarTiempo(int minutos)
        {
            this.tiempoDemorado += minutos; 
        }

        public int DevolverTiempo()
        {
            return this.tiempoDemorado;
        }
    }
}
