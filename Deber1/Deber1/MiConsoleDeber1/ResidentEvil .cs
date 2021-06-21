using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiConsoleDeber1
{
    class ResidentEvil
    {
        public string personajes;
        public string nombreSerie;
        public int capítulos;
        public string enemigos;
        public string objetos;
        public DateTime fechaCreación;
        public float pesoTemporada;
        public string nombreEscuela;
        public int numeroNiveles;
        public int numerosCasas;

        public void mostrarPersonaje()
        {
            Console.Write("Personajes : Barry, Ada, Rebecca, Claire, Jill \n");
        }
        public void mostrarNombreSerie()
        {
            Console.Write("Nombre de la serie : Resident Evil \n");
        }
        public void mostrarCapítulos()
        {
            Console.Write("En la actualidad exixten 6 capítulos \n");
        }
        public void mostrarEnemigos()
        {
            Console.Write("Nombre de enemigos : Chris, Gigante, Fanáticos, Garrador, Iron \n");
        }
        public void mostrarNumeroniveles()
        {
            Console.Write("Cuantos niveles existen \n");
        }
    }
}
