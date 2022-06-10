using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosAnimales
{
    public class Pinguino:Ave, iAve
    {
        public Pinguino(string nombre, string color) : base(nombre, color) { }

        public void nadar_animal()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("Nombre del pinguino " + nombre);
            Console.WriteLine("Su color es " + color);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

        }
        public void volar_animal()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("El pinguino " + nombre);
            Console.WriteLine("Intento volar pero no pudo!");
            Console.WriteLine("");
            Console.WriteLine("-------------------");
        }
    }
}
