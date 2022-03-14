using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Peliculas
{
    public class Estante
    {
        public List<Pelicula> peliculas;
        public String genero;

        public Estante(String genero)
        {
            
            this.genero = genero;
            peliculas = new List<Pelicula>();
        }

        public String getGenero()
        {
            return genero;
        }


        public void toString()
        {
            Console.WriteLine("ESTANTE DE GENERO "+genero);
            if (peliculas.Count == 0)
            {
                Console.WriteLine("El estante de peliculas se encuentra vacio.");
            }
            else
            {
                Console.WriteLine("En el estante se encuentran las siguientes peliculas: ");
                foreach (Pelicula p in peliculas)
                {
                    Console.WriteLine(p.nombre_pelicula);
                }
            }
            
        }

    }
}
