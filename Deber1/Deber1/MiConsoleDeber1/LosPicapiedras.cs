using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiConsoleDeber1
{
    class LosPicapiedras
    {
        public string personajes;
        public string nombreSerie;
        public int capítulos;
        public string enemigos;
        public string edadHistóri;
        public DateTime fechaCreación;
        public float pesoTemporada;
        public string nombreEscuela;
        public int numeroJuguetesSueneo;
        public int numerosCasas;

        public void mostrarPersonaje()
        {
            Console.Write("Personajes : Pedro, Vilma, Pablo, Betty, Bam-Bam, Pebbles, Gazu, Dino");
        }
        public void mostrarNombreSerie()
        {
            Console.Write("Nombre de la serie : Los Picapiedra");
        }
        public void mostrarCápitulos()
        {
            Console.Write("En la actualidad hay 166 capítulos");
        }
        public void mostrarFechaCreación()
        {
            Console.Write("Fecha del primer capitrulo: 30 de septiembre de 1960");
        }
        public void mostrarEdadHistória()
        {
            Console.Write("La história se realizó en ña edad de piedra");
        }
    }
}
