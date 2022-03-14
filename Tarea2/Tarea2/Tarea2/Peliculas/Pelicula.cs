using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Peliculas
{
    public class Pelicula
    {
        public String nombre_pelicula;
        public String genero;
        
        public Pelicula(String nombre_pelicula, String genero)
        {
            this.nombre_pelicula = nombre_pelicula;
            this.genero = genero;
        }

        public String getNombrePelicula()
        {
            return nombre_pelicula;
        }

        public String getGenero()
        {
            return genero;
        }

        public String toString()
        {
            return "El nombre de la pelicula es " + nombre_pelicula + " y pertenece al estante de genero " + genero;
        }
    }
}
