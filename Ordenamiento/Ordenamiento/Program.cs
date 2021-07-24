using Miguel.Ordenamiento;
using System;
using System.Collections.Generic;

namespace Ordenamiento
{
    class Program
    {-
        static void Main(string[] args)
        {
            Console.WriteLine("Ordenamiento");
            //Menor es el primero = 2
            //1, 6, -9, 50
            //-9, 6, 1, 50

            //6, -1, 50
            //1, 6, 50

            //6, 50

            //Salida-9, 6, 1, 50

            //Ordenador<int> ordenador = new Ordenador<int>();

            //List<int> desordenados = new List<int> { 3, 8, 1, 9, 5, 18, -1 };
            //List<int> ordenados = ordenador.Ordenar(desordenados);
            //foreach (var numero in ordenados)
            //    Console.WriteLine(numero);

            Ordenador ordenador = new Ordenador();
            var desordenadosCarros = new List<IComparable>
            {
                new Carro{Precio = 12 },
                new Carro{Precio = 9  },
                new Carro{Precio = 46 },
                new Carro{Precio = 15 },
                new Carro{Precio = 4  },
            };
            var ordenadosCarros = ordenador.Ordenar(desordenadosCarros);
            foreach (Carro carro in ordenadosCarros)
                Console.WriteLine(carro.ToString());

            var  puestoTrabajo = new List<IComparable>
            {
                new puestoTrabajo
                {
                    Posicion = 10
                },
                 new puestoTrabajo
                {
                    Posicion = 9
                },
                  new puestoTrabajo
                {
                    Posicion = 7
                },
                   new puestoTrabajo
                {
                    Posicion = 2
                },
            };

            var puestoTrabajoOrdenados = ordenador.Ordenar(puestoTrabajo);
            foreach (puestoTrabajo Actual in puestoTrabajoOrdenados)
                Console.WriteLine(Actual.Posicion);

            //List<float> desordenados1 = new List<float> { 3.1f, 8.2f, 1.5f, 9.9f, 5.01f, 18.009f, -1.0f };
            //List<float> ordenados1 = ordenador.Ordenar(desordenados1);
            //foreach (var numero in ordenados1)
            //    Console.WriteLine(numero);

        }
    }
}

