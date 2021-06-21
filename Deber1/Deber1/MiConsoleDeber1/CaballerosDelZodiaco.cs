using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiConsoleDeber1
{
    class CaballerosDelZodiaco
    {
        public string personajes;
        public string nombreSerie;
        public int capítulos;
        public string enemigos;
        public string odjetos;
        public DateTime fechaCreación;
        public float pesoTemporada;
        public string nombreArmaduras;
        public int numeroPoder;
        public int numerosCasas;

        public void mostrarPersonaje()
        {
            Console.Write("Personajes : Seiya, Shiryu, Hyōga, Shun, Ikki, Saori Kido \n");
        }
        public void mostrarNombreSerie()
        {
            Console.Write("Nombre de la serie : los Caballeros del Zodiaco \n");
        }
        public void mostrarNumeroPoder()
        {
            Console.Write("Cuantos poderes tienen \n");
        }
        public void mostrarFechaCreación()
        {
            Console.Write("Fecha del primer capitrulo: 3 de Diciembre de 1985 \n");
        }
        public void mostrarArmaduras()
        {
            Console.Write("Armaduras : Pegaso, Dragón, Cisne, Andrómeda, Fénix, Diosa \n");
        }
    }
}
