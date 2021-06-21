using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiConsoleDeber1
{
    class Halcones_Galácticos
    {
        public string personajes;
        public string nombreSerie;
        public int capítulos;
        public string enemigos;
        public string objetos;
        public DateTime fechaCreación;
        public float pesoTemporada;
        public string nombreEscuela;
        public int numeroJuguetesSueneo;
        public int numerosCasas;

        public void mostrarPersonaje()
        {
            Console.Write("Personajes : Capitán, Rayo, Vaquero, Acerino, Acerina, Niño \n");
        }
        public void mostrarNombreSerie()
        {
            Console.Write("Nombre de la serie : Halcones Galácticos \n");
        }
        public void mostrarCapítulos()
        {
            Console.Write("En la actualidad hay 65 capítulos \n");
        }
        public void mostrarFechaCreación()
        {
            Console.Write("Fecha del primer capitrulo: 8 de diciembre de 1986 \n");
        }
        public void mostrarObjetos()
        {
            Console.Write("Objetos : Gorra, sinturón, Guitarra, Alas \n");
        }
    }
}
