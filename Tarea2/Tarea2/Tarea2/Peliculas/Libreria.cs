using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Peliculas
{
    public class Libreria
    {
        public List<Estante> estantes;

        public Libreria()
        {
            estantes = new List<Estante>();
            estantes.Add(new Estante("Accion"));
            estantes.Add(new Estante("Aventura"));
            estantes.Add(new Estante("Comedia"));
            estantes.Add(new Estante("Drama"));
            estantes.Add(new Estante("Terror"));
            estantes.Add(new Estante("Musical"));
            estantes.Add(new Estante("Ciencia ficcion"));
            estantes.Add(new Estante("Suspenso"));
            estantes.Add(new Estante("Infantil"));
            estantes.Add(new Estante("Romantico"));
        }

        
    }
}
