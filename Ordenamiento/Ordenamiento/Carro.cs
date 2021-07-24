using System;

namespace Ordenamiento
{
    internal class Carro : IComparable
    {

        public int Precio { get; set; }
        public DateTime FechaEnsamblado { get; set; }

        public int CompareTo(object otroCarro)

        {
        return this.Precio - ((Carro)otroCarro).Precio;
            //negativo si el codigo actual (this) es menor que el obj
            //0 => si son iguales
            //popsitivo si el codigo actual (this) es mayor que el obj
        }
        public new string ToString()
        {
            return Precio.ToString();
        }
    }
}