using System;
 namespace Examen_poo_Danna
 {
      public class Estudiante_Primaria :Estudiante,IEstudiante
      {
        public int valor_fijo {set; get;}
        public int anual {set; get;}

        public EstudiantePrimaria(int anual,string Nombre, string Apellido,string Institucion,int Cedula):base(Nombre, Apellido, Institucion,Cedula){
        this.valor_fijo = 100;
        this.anual = anual;
      }
       public void mostrar_datos(){
               Console.WriteLine("Nombre: "+Nombre);
               Console.WriteLine("Apellido:"+ Apellido);
               Console.WriteLine("Institucion: "+Institucion);
               Console.WriteLine("Cedula: "+ Cedula);
               Console.WriteLine("años de estudio: "+anual);
    }
 }
 }