using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Peliculas
{
    public class Registro
    {
        public Libreria libreria;
        public Registro()
        {
            libreria = new Libreria();
        }
        
        public void agregarPelicula(Pelicula pelicula)
        {
            
            foreach (Estante estante in libreria.estantes)
            {
                if (estante.genero.Equals(pelicula.genero))
                {
                    estante.peliculas.Add(pelicula);
                }
            }
        }

        public void verTodasLasPeliculas()
        {
            foreach (Estante estante in libreria.estantes)
            {
                estante.ToString();
            }
        }

        public void verEstante(Estante estante)
        {
            estante.informacionEstante();
        }

        public void buscarPelicula(String nombre)
        {
            Pelicula pelicula = null;

            foreach (Estante estante in libreria.estantes)
            {
                foreach (Pelicula peli in estante.peliculas)
                {
                    if (peli.nombre_pelicula.Equals(nombre))
                    {
                        pelicula = peli;
                    }
                }
            }

            if (pelicula != null)
            {
                Console.WriteLine("Si se encontro");
                Console.WriteLine(pelicula.toString());
            }
            else
            {
                Console.WriteLine("La pelicula no se encuentra en la libreria");
            }
        }
    }
}
