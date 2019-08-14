using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectosSenova
{
    public class Proyecto
       
    {

        #region Atrubutos
        public List<Proyecto> proyectos = new List<Proyecto>();// asi se define una lista

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
        public void ObtenerMayores(int x)
        {
            
            List<Proyecto> pro20 = new List<Proyecto>();
            foreach (var item in proyectos)
            {
                
                if (item.Codigo>x)
                {
                    pro20.Add(item);

                }
            }
            ImprimirProyecto(pro20); 
        }

        public void IngresarProyecto()
        {
            var res = "y";
            while (res == "y")
            {

                Proyecto miproyecto = new Proyecto();
                Console.WriteLine("Ingrese el nombre del proyecto: ");
                miproyecto.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el codigo: ");
                miproyecto.Codigo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el Area del proyecto: ");
                miproyecto.Area = Console.ReadLine();
                Console.WriteLine("Ingrese la duracion del proyecto: ");
                miproyecto.Duracion = int.Parse(Console.ReadLine());
                proyectos.Add(miproyecto);
                Console.WriteLine("desea agregar otro proyecto");
                res = Console.ReadLine();
            }

        }

       public void ImprimirProyecto(List<Proyecto> proyecto1)
        {
            foreach (var item in proyecto1)
            {


                Console.WriteLine($" Nombre: {item.Nombre}");
                Console.WriteLine($" Codigo: {item.Codigo}");
                Console.WriteLine($" Area: {item.Area}");
                Console.WriteLine($" Duracion: {item.Duracion}");
            }
        }

        #endregion
    }
}
