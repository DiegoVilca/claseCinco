using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class carrera
    {
        public string nombre;
        public string fecha;
        public string lugar;
        //Deprecated por coleccion
        //auto autoUno;
        //auto autoDos;
        //auto autoTres;
        //auto autoCuatro;
        //auto autoCinco;
        //auto autoSeis;

        #region constructores

        public carrera(string nombre, string fecha, string lugar) :this()
        {
            this.nombre = nombre;
            this.fecha = fecha;
            this.lugar = lugar;

        }
        public carrera()
        {
            ListaAutos = new List<auto>();

            for (int i = 0; i < 5; i++)
            {
                ListaAutos.Add(new auto());
            }

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
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Carrera: ");

            foreach (auto item in this.ListaAutos)
            {
                sb.AppendLine(item.Devolverstring());
            }
            Console.Write(sb.ToString());
            
        }




        /// <summary>
        /// Asigna kilometraje a cada auto por cada minuto que hizo de carrera. 
        /// </summary>
        /// <param name="minutos">Duracion de la carrera</param>
        private void PorTiempo(kilometro minutos)
        {
            for (int i = 0; i < (int) minutos; i++)
            {
                foreach (auto item in ListaAutos)
                {
                    item.AgregarKilometro(randomKilometro.Next(10, 100));
                }
            }

            this.Ganador();
            this.MostrarKilometros();
        }


        
        /// <summary>
        /// Elige como ganador al auto con mas kilometros
        /// </summary>
        private void Ganador()
        {
            auto mayor = new auto();
            auto menor = new auto();

            for (int elemento= 0; elemento  < ListaAutos.Count(); elemento++)
            {
                if (elemento == 0)
                {
                    mayor = ListaAutos[elemento];
                    menor = ListaAutos[elemento];
                    continue;
                }

                if ((int)ListaAutos[elemento].DevolverKilometro() < menor.DevolverKilometro())
                    menor = ListaAutos[elemento];
                if ((int)ListaAutos[elemento].DevolverKilometro() > mayor.DevolverKilometro())
                    mayor = ListaAutos[elemento];

            }

            
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
                foreach (auto item in ListaAutos)
                {
                    item.AgregarTiempo(randomTiempo.Next(10, 100));
                }
            }

            this.GanadorTiempo();
            this.MostrarTiempo();

        }

        /// <summary>
        /// Elige como ganador al auto con menor tiempo
        /// </summary>
        private void GanadorTiempo()
        {
            
            auto mayor = new auto();
            auto menor = new auto();

            for (int elemento = 0; elemento < ListaAutos.Count(); elemento++)
            {
                if (elemento == 0)
                {
                    mayor = ListaAutos[elemento];
                    menor = ListaAutos[elemento];
                    continue;
                }

                if ((int)ListaAutos[elemento].DevolverTiempo() < menor.DevolverTiempo())
                    menor = ListaAutos[elemento];
                if ((int)ListaAutos[elemento].DevolverTiempo() > mayor.DevolverTiempo())
                    mayor = ListaAutos[elemento];

                
            }

            MostrarCarrera();
            Console.Write("Ganador: \n" + menor.Devolverstring());


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
