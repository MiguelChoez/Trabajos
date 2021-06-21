using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiConsoleDeber1
{
    class Simpsons
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
            Console.Write("Personajes : Homero, Lisa, Bart, Marge, Maggie \n");
        }
        public void mostrarNombreSerie()
        {
            Console.Write("Nombre de la serie : los Simpson \n");
        }
        public void mostrarCapítulos()
        {
            Console.Write("En la actualidad hay 31 capítulos \n");
        }
        public void mostrarFechaCreación()
        {
            Console.Write("Fecha del primer capitrulo: 19 de Abril del 1987 \n");
        }
        public void mostrarObjetos()
        {
            Console.Write("Objetos : Corro, Casa, Patineta, bicicleta \n");
        }
    }

}
