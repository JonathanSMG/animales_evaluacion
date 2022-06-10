using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosAnimales
{
    public class Condor:Ave, iAve
    {
        public Condor(string nombre, string color) : base(nombre, color) { }
        public void imprimir_datos()
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("Nombre del condor " + nombre);
            Console.WriteLine("Su color es "+color);
            Console.WriteLine("");
            Console.WriteLine("-------------------");

        }
        public void nadar_animal()
        {
            Console.WriteLine("el condor " + nombre+ " Nada");

        }

        public void volar_animal()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("");
            Console.WriteLine("El Condor "+nombre);
            Console.WriteLine("Vuelaaaaaaaaaaaa");
            Console.WriteLine("");
            Console.WriteLine("-------------------");
        }
    }
}
