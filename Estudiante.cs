using System;

namespace Examen_poo_Danna
{
 class Estudiante
 {
    
     public string Nombre { set ; get;}
     public string Apellido { set ; get;}
     public string Institucion { set ; get;}
     public int Cedula { set ; get;}
     
    public void Estudiante(string nombre, string Apellido,string institucion, int Cedula)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Institucion = Institucion;
        this.Cedula = Cedula;
    }
 } 
}