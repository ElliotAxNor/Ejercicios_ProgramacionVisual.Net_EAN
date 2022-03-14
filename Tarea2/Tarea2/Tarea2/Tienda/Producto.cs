using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tienda
{
    public class Producto
    {
        public String nombre;
        public int precio;

        public Producto(String nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public String toString()
        {
            return nombre + " con un precio de $" + precio;
        }

    }
}
