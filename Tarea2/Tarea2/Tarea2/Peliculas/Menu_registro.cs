using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Peliculas
{
    public class Menu_registro
    {
        Registro registro;

        public Menu_registro()
        {
            registro = new Registro();
        }
        

        public void iniciarMenu()
        {
            int opcion = 0;
            while(opcion != 4)
            {
                mostrarMenu();
                Console.WriteLine("Elige una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                while (opcion <= 0 || opcion > 4)
                {
                    Console.WriteLine("Opcion incorrecta.");
                    Console.WriteLine("Elige una opcion: ");
                    opcion = int.Parse(Console.ReadLine());
                }

                if (opcion == 1)
                {
                    agregarPelicula();
                }
                if (opcion == 2)
                {
                    verPeliculasEstante();
                }
                if (opcion == 3)
                {
                    registro.verTodasLasPeliculas();
                }
                if (opcion == 4)
                {
                    Console.WriteLine("Has salido");
                }
            }
        }

        public void mostrarMenu()
        {
            Console.WriteLine("----------M-E-N-U----------");
            Console.WriteLine("1.- Agregar pelicula.");
            Console.WriteLine("2.- Ver peliculas de cierto estante.");
            Console.WriteLine("3.- Ver todas las peliculas por estante.");
            Console.WriteLine("4.- Salir");
        }

        public Estante pedirEstante()
        {
            Console.WriteLine("ELIGE ESTANTE");
            String genero_estante = pedirGenero();
            foreach (Estante estante in registro.libreria.estantes)
            {
                if (estante.genero.Equals(genero_estante))
                {
                    return estante;
                }
            }
            return null;
        }

        public Pelicula pedirPelicula()
        {
            Console.WriteLine("INGRESAR DATOS DE LA PELICULA");
            Console.WriteLine("Nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("ELIGE GENERO");
            String genero = pedirGenero();
            return new Pelicula(nombre, genero);
        }


        public String pedirGenero()
        {
            
            Console.WriteLine("1.- Accion");
            Console.WriteLine("2.- Aventura");
            Console.WriteLine("3.- Comedia");
            Console.WriteLine("4.- Drama");
            Console.WriteLine("5.- Terror");
            Console.WriteLine("6.- Musical");
            Console.WriteLine("7.- Ciencia ficcion");
            Console.WriteLine("8.- Suspenso");
            Console.WriteLine("9.- Infantil");
            Console.WriteLine("10.- Romantico");
            Console.WriteLine("Elige un genero (1-10): ");
            int opcion = int.Parse(Console.ReadLine());
            String genero="";
            if (opcion == 1)
            {
                genero = "Accion";
            }
            if (opcion == 2)
            {
                genero = "Aventura";
            }
            if (opcion == 3)
            {
                genero = "Comedia";
            }
            if (opcion == 4)
            {
                genero = "Drama";
            }
            if (opcion == 5)
            {
                genero = "Terror";
            }
            if (opcion == 6)
            {
                genero = "Musical";
            }
            if (opcion == 7)
            {
                genero = "Ciencia ficcion";
            }
            if (opcion == 8)
            {
                genero = "Suspenso";
            }
            if (opcion == 9)
            {
                genero = "Infantil";
            }
            if (opcion == 10)
            {
                genero = "Romantico";
            }

            return genero;
        }

        public void verPeliculasEstante()
        {
            Estante estante = pedirEstante();
            estante.toString();

        }

        public void agregarPelicula()
        {
            Pelicula pelicula = pedirPelicula();
            registro.agregarPelicula(pelicula);
        }

    }
}
