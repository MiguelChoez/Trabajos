using System;

namespace Ordenamiento
{
    class puestoTrabajo : IComparable
    { 
        public int Posicion { get; set; }

        public int CompareTo(object obj)
        {
            return Posicion - ((puestoTrabajo)obj).Posicion;
        }
    }
}