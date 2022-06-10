using System;


namespace EjerciciosAnimales
{
     class Program{

        public static void Main(String[] args)
        {
            iAve condor = new Condor("rosquita", "Blanco");
            iAve gallina = new Gallina("piolin", "Amarrillo");
            iAve pato = new Pato("tanjito", "negro");
            iAve pinguin = new Pinguino("pecas", "blanco_negro");

            List<iAve> animales_lista = new List<iAve>();
            animales_lista.Add(condor);
            animales_lista.Add(gallina);
            animales_lista.Add(pato);
            animales_lista.Add(pinguin);

            foreach(iAve ave in animales_lista)
            {
                ave.imprimir_datos();
                ave.nadar_animal();
                ave.volar_animal();
            }
            
           
        }

    }
}