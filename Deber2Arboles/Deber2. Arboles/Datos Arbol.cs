using System.Linq;

namespace Deber2Arboles
{
    internal class DatosArbol
    {
        internal int ContarHojas(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo informacion in nodo.Hijos)
            {
                acumulador += informacion.Valor.Count() + informacion.Hijos.Count();
            }
            return acumulador;
        }

        internal int ContarNodos(Nodo nodo)
        {
            int acumulador = 0;
            acumulador += nodo.nodoRaiz + nodo.Hijos.Count();
            foreach (Nodo nformacion in nodo.Hijos)
            {
                acumulador += nformacion.Hijos.Count;
            }
            return acumulador;
        }
        internal int ContarNiveles(Nodo nodo)
        {
            int acumulador = 0;
            foreach (Nodo nformacion in nodo.Hijos)
            {
                acumulador += nformacion.Valor.Count();
            }
            return acumulador;
        }

    }
}