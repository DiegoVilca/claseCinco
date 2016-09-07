using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class carrera
    {

        //Deprecated por coleccion
        //auto autoUno;
        //auto autoDos;
        //auto autoTres;
        //auto autoCuatro;
        //auto autoCinco;
        //auto autoSeis;

        #region constructores

        public carrera()
        {

            ListaAutos = new List<auto>();

            //this.autoUno = new auto();
            //this.autoDos = new auto();
            //this.autoTres = new auto();
            //this.autoCuatro = new auto();
            //this.autoCinco = new auto();
            //this.autoSeis = new auto();

            randomKilometro = new Random();
            randomTiempo = new Random();

            //this.autoUno.VolverACero();
            //this.autoDos.VolverACero();
            //this.autoTres.VolverACero();
            //this.autoCuatro.VolverACero();
            //this.autoCinco.VolverACero();
            //this.autoSeis.VolverACero();

        }

        #endregion

        #region Metodos

        private bool AgregarAuto(auto unAuto)
        {
            this.ListaAutos.Add(unAuto);

            return true;
        }

        public static carrera operator +(carrera carrera, auto unAuto)
        {
            carrera.AgregarAuto(unAuto);

            return carrera;
        }

        #endregion


        public List<auto> ListaAutos;

        private Random randomKilometro;
        private Random randomTiempo;

        

        /// <summary>
        /// Este metodo muestra los competidores
        /// </summary>
        public void MostrarCarrera()
        {

            foreach (auto item in ListaAutos)
            {
                item.MostrarAuto();
            }
            
        }




        /// <summary>
        /// Asigna kilometraje a cada auto por cada minuto que hizo de carrera. 
        /// </summary>
        /// <param name="minutos">Duracion de la carrera</param>
        private void PorTiempo(kilometro minutos)
        {
            for (int i = 0; i < (int) minutos; i++)
            {
                //this.autoUno.AgregarKilometro(randomKilometro.Next(10, 100));
                //this.autoDos.AgregarKilometro(randomKilometro.Next(10, 100));
                //this.autoTres.AgregarKilometro(randomKilometro.Next(10, 100));
                //this.autoCuatro.AgregarKilometro(randomKilometro.Next(10, 100));
                //this.autoCinco.AgregarKilometro(randomKilometro.Next(10, 100));
                //this.autoSeis.AgregarKilometro(randomKilometro.Next(10, 100));
            }

            this.Ganador();
            this.MostrarKilometros();
        }


        
        /// <summary>
        /// Elige como ganador al auto con mas kilometros
        /// </summary>
        private void Ganador()
        {
            
        }// Fin metodo Ganador()


        /// <summary>
        /// Muestra kilometros recorridos por cada competidor
        /// </summary>
        private void MostrarKilometros()
        {
           
        }


        


        /// <summary>
        /// Asigna a cada auto el tiempo en minutos en el cual realizo su recorrido
        /// </summary>
        /// <param name="distancia">Kilometros recorridos</param>
        private void PorDistancia(tiempo distancia)
        {
            for (int i = 0; i < (int)distancia; i++)
            {
                
            }

            this.GanadorTiempo();
            this.MostrarTiempo();

        }

        /// <summary>
        /// Elige como ganador al auto con menor tiempo
        /// </summary>
        private void GanadorTiempo()
        {
            


        }//Fin metodo GanadorTiempo

        /// <summary>
        /// Muestra el tiempo que hizo cada auto
        /// </summary>
        private void MostrarTiempo()
        {
            
        }


        //---------------------------------------------------------

        public void CorrerCarrera(kilometro distancia)
        {
            this.PorTiempo(distancia); //distancia recorrida en x tiempo

        }//fin CorrerCarrera(Kilometro distancia)



        public void CorrerCarrera(tiempo minutos)
        {
            this.PorDistancia(minutos); //tiempo recorrido en x distancia

        }//fin CorrerCarrera(Tiempo minutos)


        //Ver diferencias colecciones generic, no generic

    }//Fin claseTres
}
