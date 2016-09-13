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
        private string _nombrePiloto;
        public string NombrePiloto
        {
            get { return this._nombrePiloto; }
            set { this._nombrePiloto = value; }
        }

        public rueda di;
        public rueda dd;
        public rueda ti;
        public rueda td;
        public static int contadorDeObjetos;
        private kilometro _kilometrosRecorridos;
        private tiempo _tiempoDemorado;
        private static Random numeroRandom;

        
        
        
        public string DatosEnString
        { 
            get
            {
                return this.DevolverStringParaListado();
            }
        }




        #region Constructores

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

            this._kilometrosRecorridos = 0; //previamente casteados a int
            this._tiempoDemorado = 0;

        }


        //Sobrecarga de constructor
        public auto(string nombrePiloto, eFabricante fabricante)
            : this()
        {
            this._nombrePiloto = nombrePiloto;
            this.fabricante = fabricante;
        }


        //constructor estatico
        //no acepta modificadores de visibilidad
        static auto()   
        { 
            //atributos estaticos
            auto.contadorDeObjetos = 0;

            auto.numeroRandom = new Random();
  
        }

        #endregion 



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
            this._kilometrosRecorridos = 0;
            this._tiempoDemorado = 0;
        }

        public void AgregarKilometro(int kilometros)//deprecated
        {
            this._kilometrosRecorridos += kilometros;
        }

        public int DevolverKilometro()
        {
            return (int)this._kilometrosRecorridos;
        }

        public void AgregarTiempo(int minutos)//deprecated
        {
            this._tiempoDemorado += minutos; 
        }

        public int DevolverTiempo()
        {
            return (int)this._tiempoDemorado;
        }

        public void Agregar(kilometro miKm)
        {
            this._kilometrosRecorridos += (int) miKm;
        }

        public void Agregar(tiempo miTiempo)
        {
            this._tiempoDemorado += (int) miTiempo;
        }


        public string Devolverstring()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Fabricante: "+ this.fabricante);
            sb.AppendLine("Kilometros: " + this._kilometrosRecorridos);
            sb.AppendLine("Tiempo: " + this._tiempoDemorado);

            return sb.ToString();
        }

        private string DevolverStringParaListado() //Es utilizada por la propiedad DatosEnString
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Fabricante: " + this.fabricante);
            sb.AppendLine(" - Piloto: " + this._nombrePiloto);
            

            return sb.ToString();
        }



    }
}
