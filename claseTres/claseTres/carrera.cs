using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    public class carrera
    {
        auto autoUno;
        auto autoDos;
        auto autoTres;
        auto autoCuatro;
        auto autoCinco;
        auto autoSeis;

        private Random randomKilometro;
        private Random randomTiempo;

        public carrera()
        {
            this.autoUno = new auto();
            this.autoDos = new auto();
            this.autoTres = new auto();
            this.autoCuatro = new auto();
            this.autoCinco = new auto();
            this.autoSeis = new auto();

            randomKilometro = new Random();
            randomTiempo = new Random();

            this.autoUno.VolverACero();
            this.autoDos.VolverACero();
            this.autoTres.VolverACero();
            this.autoCuatro.VolverACero();
            this.autoCinco.VolverACero();
            this.autoSeis.VolverACero();

        }

        /// <summary>
        /// Este metodo muestra los competidores
        /// </summary>
        public void MostrarCarrera()
        {
            this.autoUno.MostrarAuto();
            this.autoDos.MostrarAuto();
            this.autoTres.MostrarAuto();
            this.autoCuatro.MostrarAuto();
            this.autoCinco.MostrarAuto();
            this.autoSeis.MostrarAuto();
        }




        /// <summary>
        /// Asigna kilometraje a cada auto por cada minuto que hizo de carrera. 
        /// </summary>
        /// <param name="minutos">Duracion de la carrera</param>
        private void PorTiempo(int minutos)
        {
            for (int i = 0; i < minutos; i++)
            {
                this.autoUno.AgregarKilometro(randomKilometro.Next(10, 100));
                this.autoDos.AgregarKilometro(randomKilometro.Next(10, 100));
                this.autoTres.AgregarKilometro(randomKilometro.Next(10, 100));
                this.autoCuatro.AgregarKilometro(randomKilometro.Next(10, 100));
                this.autoCinco.AgregarKilometro(randomKilometro.Next(10, 100));
                this.autoSeis.AgregarKilometro(randomKilometro.Next(10, 100));
            }

            this.Ganador();
            this.MostrarKilometros();
        }


        
        /// <summary>
        /// Elige como ganador al auto con mas kilometros
        /// </summary>
        private void Ganador()
        {
            if (this.autoUno.DevolverKilometro() > this.autoDos.DevolverKilometro())
            {
                if (this.autoUno.DevolverKilometro() > this.autoTres.DevolverKilometro())
                {
                    if (this.autoUno.DevolverKilometro() > this.autoCuatro.DevolverKilometro())
                    {
                        if (this.autoUno.DevolverKilometro() > this.autoCinco.DevolverKilometro())
                        {
                            if (this.autoUno.DevolverKilometro() > this.autoSeis.DevolverKilometro())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 1");
                            }
                        }
                    }

                }
            }


            if (this.autoDos.DevolverKilometro() > this.autoUno.DevolverKilometro())
            {
                if (this.autoDos.DevolverKilometro() > this.autoTres.DevolverKilometro())
                {
                    if (this.autoDos.DevolverKilometro() > this.autoCuatro.DevolverKilometro())
                    {
                        if (this.autoDos.DevolverKilometro() > this.autoCinco.DevolverKilometro())
                        {
                            if (this.autoDos.DevolverKilometro() > this.autoSeis.DevolverKilometro())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 2");
                            }
                        }
                    }

                }
            }

            if (this.autoTres.DevolverKilometro() > this.autoUno.DevolverKilometro())
            {
                if (this.autoTres.DevolverKilometro() > this.autoDos.DevolverKilometro())
                {
                    if (this.autoTres.DevolverKilometro() > this.autoCuatro.DevolverKilometro())
                    {
                        if (this.autoTres.DevolverKilometro() > this.autoCinco.DevolverKilometro())
                        {
                            if (this.autoTres.DevolverKilometro() > this.autoSeis.DevolverKilometro())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 3");
                            }
                        }
                    }

                }
            }

            if (this.autoCuatro.DevolverKilometro() > this.autoUno.DevolverKilometro())
            {
                if (this.autoCuatro.DevolverKilometro() > this.autoDos.DevolverKilometro())
                {
                    if (this.autoCuatro.DevolverKilometro() > this.autoTres.DevolverKilometro())
                    {
                        if (this.autoCuatro.DevolverKilometro() > this.autoCinco.DevolverKilometro())
                        {
                            if (this.autoCuatro.DevolverKilometro() > this.autoSeis.DevolverKilometro())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 4");
                            }
                        }
                    }

                }
            }

            if (this.autoCinco.DevolverKilometro() > this.autoUno.DevolverKilometro())
            {
                if (this.autoCinco.DevolverKilometro() > this.autoDos.DevolverKilometro())
                {
                    if (this.autoCinco.DevolverKilometro() > this.autoTres.DevolverKilometro())
                    {
                        if (this.autoCinco.DevolverKilometro() > this.autoCuatro.DevolverKilometro())
                        {
                            if (this.autoCinco.DevolverKilometro() > this.autoSeis.DevolverKilometro())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 5");
                            }
                        }
                    }

                }
            }

            if (this.autoSeis.DevolverKilometro() > this.autoUno.DevolverKilometro())
            {
                if (this.autoSeis.DevolverKilometro() > this.autoDos.DevolverKilometro())
                {
                    if (this.autoSeis.DevolverKilometro() > this.autoTres.DevolverKilometro())
                    {
                        if (this.autoSeis.DevolverKilometro() > this.autoCuatro.DevolverKilometro())
                        {
                            if (this.autoSeis.DevolverKilometro() > this.autoCinco.DevolverKilometro())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 6");
                            }
                        }
                    }

                }
            }

        }// Fin metodo Ganador()


        /// <summary>
        /// Muestra kilometros recorridos por cada competidor
        /// </summary>
        private void MostrarKilometros()
        {
            Console.WriteLine("\nKilometros recorridos por competidor\n");
            Console.WriteLine("auto 1: {0}" + this.autoUno.DevolverKilometro());
            Console.WriteLine("auto 2: {0}" + this.autoDos.DevolverKilometro());
            Console.WriteLine("auto 3: {0}" + this.autoTres.DevolverKilometro());
            Console.WriteLine("auto 4: {0}" + this.autoCuatro.DevolverKilometro());
            Console.WriteLine("auto 5: {0}" + this.autoCinco.DevolverKilometro());
            Console.WriteLine("auto 6: {0}" + this.autoSeis.DevolverKilometro());
        }


        


        /// <summary>
        /// Asigna a cada auto el tiempo en minutos en el cual realizo su recorrido
        /// </summary>
        /// <param name="distancia">Kilometros recorridos</param>
        private void PorDistancia(int distancia)
        {
            for (int i = 0; i < distancia; i++)
            {
                this.autoUno.AgregarTiempo(randomTiempo.Next(10, 100));
                this.autoDos.AgregarTiempo(randomTiempo.Next(10, 100));
                this.autoTres.AgregarTiempo(randomTiempo.Next(10, 100));
                this.autoCuatro.AgregarTiempo(randomTiempo.Next(10, 100));
                this.autoCinco.AgregarTiempo(randomTiempo.Next(10, 100));
                this.autoSeis.AgregarTiempo(randomTiempo.Next(10, 100));
            }

            this.GanadorTiempo();
            this.MostrarTiempo();

        }

        /// <summary>
        /// Elige como ganador al auto con menor tiempo
        /// </summary>
        private void GanadorTiempo()
        {
            if (this.autoUno.DevolverTiempo() < this.autoDos.DevolverTiempo())
            {
                if (this.autoUno.DevolverTiempo() < this.autoTres.DevolverTiempo())
                {
                    if (this.autoUno.DevolverTiempo() < this.autoCuatro.DevolverTiempo())
                    {
                        if (this.autoUno.DevolverTiempo() < this.autoCinco.DevolverTiempo())
                        {
                            if (this.autoUno.DevolverTiempo() < this.autoSeis.DevolverTiempo())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 1");
                            }
                        }
                    }
                }
            }


            if (this.autoDos.DevolverTiempo() < this.autoUno.DevolverTiempo())
            {
                if (this.autoDos.DevolverTiempo() < this.autoTres.DevolverTiempo())
                {
                    if (this.autoDos.DevolverTiempo() < this.autoCuatro.DevolverTiempo())
                    {
                        if (this.autoDos.DevolverTiempo() < this.autoCinco.DevolverTiempo())
                        {
                            if (this.autoDos.DevolverTiempo() < this.autoSeis.DevolverTiempo())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 2");
                            }
                        }
                    }
                }
            }


            if (this.autoTres.DevolverTiempo() < this.autoUno.DevolverTiempo())
            {
                if (this.autoTres.DevolverTiempo() < this.autoDos.DevolverTiempo())
                {
                    if (this.autoTres.DevolverTiempo() < this.autoCuatro.DevolverTiempo())
                    {
                        if (this.autoTres.DevolverTiempo() < this.autoCinco.DevolverTiempo())
                        {
                            if (this.autoTres.DevolverTiempo() < this.autoSeis.DevolverTiempo())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 3");
                            }
                        }
                    }
                }
            }


            if (this.autoCuatro.DevolverTiempo() < this.autoUno.DevolverTiempo())
            {
                if (this.autoCuatro.DevolverTiempo() < this.autoDos.DevolverTiempo())
                {
                    if (this.autoCuatro.DevolverTiempo() < this.autoTres.DevolverTiempo())
                    {
                        if (this.autoCuatro.DevolverTiempo() < this.autoCinco.DevolverTiempo())
                        {
                            if (this.autoCuatro.DevolverTiempo() < this.autoSeis.DevolverTiempo())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 4");
                            }
                        }
                    }
                }
            }

            if (this.autoCinco.DevolverTiempo() < this.autoUno.DevolverTiempo())
            {
                if (this.autoCinco.DevolverTiempo() < this.autoDos.DevolverTiempo())
                {
                    if (this.autoCinco.DevolverTiempo() < this.autoTres.DevolverTiempo())
                    {
                        if (this.autoCinco.DevolverTiempo() < this.autoCuatro.DevolverTiempo())
                        {
                            if (this.autoCinco.DevolverTiempo() < this.autoSeis.DevolverTiempo())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 5");
                            }
                        }
                    }
                }
            }

            if (this.autoSeis.DevolverTiempo() < this.autoUno.DevolverTiempo())
            {
                if (this.autoSeis.DevolverTiempo() < this.autoDos.DevolverTiempo())
                {
                    if (this.autoSeis.DevolverTiempo() < this.autoTres.DevolverTiempo())
                    {
                        if (this.autoSeis.DevolverTiempo() < this.autoCuatro.DevolverTiempo())
                        {
                            if (this.autoSeis.DevolverTiempo() < this.autoCinco.DevolverTiempo())
                            {
                                Console.WriteLine("\nEl ganador es el auto numero 6");
                            }
                        }
                    }
                }
            }



        }//Fin metodo GanadorTiempo

        /// <summary>
        /// Muestra el tiempo que hizo cada auto
        /// </summary>
        private void MostrarTiempo()
        {
            Console.WriteLine("\nCantidad de tiempo por competidor\n");
            Console.WriteLine("Minutos auto 1: {0}",this.autoUno.DevolverTiempo());
            Console.WriteLine("Minutos auto 3: {0}", this.autoDos.DevolverTiempo());
            Console.WriteLine("Minutos auto 4: {0}", this.autoTres.DevolverTiempo());
            Console.WriteLine("Minutos auto 5: {0}", this.autoCuatro.DevolverTiempo());
            Console.WriteLine("Minutos auto 6: {0}", this.autoCinco.DevolverTiempo());
            Console.WriteLine("Minutos auto 1: {0}", this.autoSeis.DevolverTiempo());
        }


        //---------------------------------------------------------

        public void CorrerCarrera(kilometro distancia)
        {
            this.PorTiempo(distancia.cantidad); //distancia recorrida en x tiempo

        }//fin CorrerCarrera(Kilometro distancia)



        public void CorrerCarrera(tiempo minutos)
        {
            this.PorDistancia(minutos.cantidad); //tiempo recorrido en x distancia

        }//fin CorrerCarrera(Tiempo minutos)




    }//Fin claseTres
}
