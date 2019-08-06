using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectosSenova
{
    public class Proyecto
       
    {
        #region Atrubutos

        #endregion
        #region Propiedades
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }
        #endregion

        #region Constructores
        //ctor
        public Proyecto(String nombre,double codigo ,string area, int duracion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Area = area;
            Duracion = duracion;
        }
        public Proyecto()
        {

        }
        public Proyecto(string area,int duracion)
        {
            Area = area;
            Duracion = duracion;
        }
        #endregion

        #region Metodos
        public void IngresarProyecto()
        {
            Console.WriteLine("Ingrese el nombre del proyecto: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo: ");
            Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Area del proyecto: ");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese la duracion del proyecto: ");
            Duracion =  int.Parse(Console.ReadLine());

        }

       public void ImprimirProyecto()
        {
            Console.WriteLine($" Nombre: {Nombre}");
            Console.WriteLine($" Codigo: {Codigo}");
            Console.WriteLine($" Area: {Area}");
            Console.WriteLine($" Duracion: {Duracion}");
        }
        #endregion
    }
}
