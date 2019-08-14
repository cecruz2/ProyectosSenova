using System;
using System.Collections.Generic;
//obtener todos los proyectos cuyo codigo sea mayor a 20 y sea par
//ordenar los proyectos acedentemente por duracion 
//seleccionar el primesr proyecto que sea multiplo de 6
//mostar las areas de los proyectos
//seleccionar los proyectos por nombre y codigo
//sumar la duracion de todos los proyectos
//agrupar los proyectos por areas
namespace ProyectosSenova
{
    class Program
    {
        static void Main(string[] args)
        {
            //int edad;
            //int puntaje = 0;

            Proyecto miProyecto = new Proyecto();
            miProyecto.IngresarProyecto();
            List<Proyecto> proyectos = new List<Proyecto>();
            //Console.WriteLine("digite la cantidad de digitos para el codigo");
            //var x = int.Parse(Console.ReadLine());
            //miProyecto.ObtenerMayores(x);
            //Proyecto miProyecto2 = new Proyecto();
            //Proyecto miProyecto3 = new Proyecto();
            //Proyecto miProyecto4 = new Proyecto("Realidad aumentada",12540,"sistemas",10);
            //Proyecto miProyecto5 = new Proyecto("Talento Humano", 5);

            // miProyecto3.IngresarProyecto();
            // miProyecto3.ImprimirProyecto();
            //miProyecto4.ImprimirProyecto();
            //miProyecto5.ImprimirProyecto();



            //miProyecto.Area = "Sistemas";
            //miProyecto.Codigo = 12000;
            //miProyecto.Duracion = 13;
            //miProyecto.Nombre = "Desarrollo internet  de las cosas IOT";

            //Console.WriteLine($"Area: {miProyecto.Area}");
            //Console.WriteLine($"Codigo:{miProyecto.Codigo}");
            //Console.WriteLine($"Duracion:{miProyecto.Duracion}");
            //Console.WriteLine($"Nombre:{miProyecto.Nombre}");

            //miProyecto2.Area = "Redes";
            //miProyecto2.Codigo = 13000;
            //miProyecto2.Duracion = 14;
            //miProyecto2.Nombre = "Desarrollo Arduino";

            //Console.WriteLine($"Area: {miProyecto.Area}");
            //Console.WriteLine($"Codigo:{miProyecto.Codigo}");
            //Console.WriteLine($"Duracion:{miProyecto.Duracion}");
            //Console.WriteLine($"Nombre:{miProyecto.Nombre}");
            Console.ReadLine();
    



        }

    }
}
