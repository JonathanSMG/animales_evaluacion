using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosAnimales
{
    public class Ave
    {
        public string nombre { set; get; }
        public string color { set; get; }

        public Ave(string nombre, string color)
        {
            this.nombre = nombre;
            this.color = color;
        }
    }
}
