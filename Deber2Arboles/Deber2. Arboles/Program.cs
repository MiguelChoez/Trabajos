using System;

namespace Deber2Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {

                Valor = "/",
                nivel = 0,
                Hijos ={
                    new Nodo{
                        Valor="*",
                        Hijos={
                            new Nodo{
                                Valor="1"
                            }
                        }
                    },
                    new Nodo{
                        Valor ="-",
                        Hijos={
                            new Nodo{
                                Valor="3"
                            },
                            new Nodo{
                                Valor="5"
                            }
                        }
                    },
                    new Nodo{
                        Valor="+",
                        Hijos={
                            new Nodo{
                                Valor="7"
                            },
                            new Nodo{
                                Valor="9"
                            },
                            new Nodo{
                                Valor="8"
                            }

                        }
                    }



                },
            };

            DatosArbol datosArbol = new DatosArbol();
            Console.WriteLine($" Numero de hojas del arbol es  : {datosArbol.ContarHojas(raiz)}");
            Console.WriteLine($" Numero de niveles del arbol es  : {datosArbol.ContarNiveles(raiz)}");
            Console.WriteLine($" Numero de nodos del arbol es  : {datosArbol.ContarNodos(raiz)}");


        }
    }
}
