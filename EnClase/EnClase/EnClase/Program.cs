using System;

namespace EnClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos");
            Console.WriteLine("Ingrese su iformación personal");

            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su aprllido");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese su cedula");
            string cedula = Console.ReadLine();

            Console.WriteLine("Es mayor de Edad");
            bool esMayorEdad = Console.ReadLine().ToUpper() == "SI";

            int edad = IngresarEdad();

            float estatura = IngresarEstatura();

            Console.WriteLine("Ingrese su nota final");
            string notaFinal = Console.ReadLine();
            double notaFinal1 = double.Parse(notaFinal);

            Console.WriteLine("Ingrese su color favorito");
            string colorFavorito = Console.ReadLine();

            Console.WriteLine("Ingrese su talla de camiseta");
            string tallaCamiseta = Console.ReadLine();
            float tallaCamiseta1 = float.Parse(tallaCamiseta);

            Console.WriteLine("Ingrese su mascota favorita");
            string animalFavorito = Console.ReadLine();

            var persona = new Persona
            {
                nombre = nombre,
                apellido = apellido,
                cedula = cedula,
                esMayorEdad = esMayorEdad,
                edad = edad,
                estatura = estatura,
                notaFinal = notaFinal1,
                colorFavorito = colorFavorito,
                tallaCamiseta = tallaCamiseta1,
                animalFavorito = animalFavorito
            };

            Console.WriteLine("Pro favor ingrese la siguiente información:");
            Console.Write($"Nombre: {persona.nombre} ");
            Console.Write($"Apellido: {persona.apellido} ");
            Console.Write($"Su numero de Cedula es: {persona.cedula} ");
            Console.Write($"Mayoria de Edad: {persona.esMayorEdad} ");
            Console.Write($"Edad: {persona.edad} ");
            Console.Write($"Estatura {persona.estatura} ");
            Console.Write($"su nota final es: {persona.notaFinal} ");
            Console.Write($"Su color Favorito es: {persona.colorFavorito} ");
            Console.Write($"Su Talla de Camiseta es: {persona.tallaCamiseta} ");
            Console.Write($"Su animal Favorito: {persona.animalFavorito} ");

            Console.WriteLine("Gracias por su Colaboración");
            Console.ReadKey();
        }
        static int IngresarEdad()
        {
            Console.Write("Ingrese su edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Opción denegada intente nuevamente : ingrese un numero");
                }
                else
                {
                    break;
                }
            }
            return edad1;

        }
        static float IngresarEstatura()
        {
            Console.Write("Ingrese su estatura: ");
            float estatura1;
            while (true)
            {
                string estatura = Console.ReadLine();
                if (!float.TryParse(estatura, out estatura1))
                {
                    Console.Write("Opción denegada intente nuevamente : ingrese un numero decimal");
                }
                else
                {
                    break;
                }
            }
            return estatura1;

        }
    }
}
