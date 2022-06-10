using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosAnimales
{
    public class Gallina : Ave, iAve
    {
        public Gallina(string nombre, string color) : base(nombre, color) { }

        public void imprimir_datos()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("Nombre de la Gallina " + nombre);
            Console.WriteLine("Su color es " + color);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

        }
        public void nadar_animal()
        {
            Console.WriteLine("la gallina " + nombre+ " Nada");

        }
        public void volar_animal()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("La gallina " + nombre);
            Console.WriteLine("Intento volar pero no pudo!");
            Console.WriteLine("");
            Console.WriteLine("-------------------");
        }
    }
}
