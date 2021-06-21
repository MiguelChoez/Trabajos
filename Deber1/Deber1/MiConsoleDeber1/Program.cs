using System;

namespace MiConsoleDeber1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("SELECCIONE UN NUMERO SEGUN CORRESPONDA\n" +
                "\n1.- lOS Simpsons" +
                "\n2.- Caballeros Del Zodiaco" +
                "\n3.- Los Picapiedras" +
                "\n4.- Resident Evil" +
                "\n5.- Halcones Galácticos" +
                "\n6.- Salir");

            string s1 = null;
            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    var simp = new Simpsons();
                    simp.mostrarPersonaje();
                    simp.mostrarNombreSerie();
                    simp.mostrarCapítulos();
                    simp.mostrarFechaCreación();
                    simp.mostrarObjetos();
                    break;

                case "2":
                    var caballeros = new CaballerosDelZodiaco();
                    caballeros.mostrarPersonaje();
                    caballeros.mostrarNombreSerie();
                    caballeros.mostrarNumeroPoder();
                    caballeros.mostrarFechaCreación();
                    caballeros.mostrarArmaduras();
                    break;

                case "3":
                    var picapiedras = new LosPicapiedras();
                    picapiedras.mostrarPersonaje();
                    picapiedras.mostrarNombreSerie();
                    picapiedras.mostrarCápitulos();
                    picapiedras.mostrarFechaCreación();
                    picapiedras.mostrarEdadHistória();
                    break;

                case "4":
                    var residen = new ResidentEvil();
                    residen.mostrarPersonaje();
                    residen.mostrarNombreSerie();
                    residen.mostrarCapítulos();
                    residen.mostrarEnemigos();
                    residen.mostrarNumeroniveles();
                    break;

                case "5":
                    var halcones = new Halcones_Galácticos();
                    halcones.mostrarPersonaje();
                    halcones.mostrarNombreSerie();
                    halcones.mostrarCapítulos();
                    halcones.mostrarFechaCreación();
                    halcones.mostrarObjetos();
                    break;

                default:
                    Console.WriteLine("Opción elegida incorrecta, intente nuevamente");
                    break;
            }
            Console.ReadKey();
        }


    }
}