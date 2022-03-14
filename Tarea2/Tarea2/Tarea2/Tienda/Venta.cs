using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Tienda
{
    public class Venta
    {

        public List<Producto> productos;
        public double total;
        public Venta(List<Producto> productos, int total)
        {
            this.productos = productos;
            this.total = total;

        }

        public void toString()
        {
            Console.WriteLine("Productos:");
            foreach(Producto producto in productos)
            {
                Console.WriteLine();
            }
        }
    }
}
