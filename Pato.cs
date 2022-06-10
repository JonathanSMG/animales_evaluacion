using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosAnimales
{
    public class Pato: Ave,iAve

    {
        public Pato(string nombre, string color) : base(nombre, color) { }

        public void imprimir_datos()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("Nombre del pato " + nombre);
            Console.WriteLine("Su color es " + color);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

        }
        public void nadar_animal()
        {
            Console.WriteLine("el pato " + nombre+ " Nada");

        }
        public void volar_animal()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("El Pato " + nombre);
            Console.WriteLine("Intento volar pero no pudo!");
            Console.WriteLine("");
            Console.WriteLine("-------------------");
        }
    }
}
