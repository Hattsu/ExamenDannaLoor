using System;

namespace Examen_poo_Danna
{
    class Estudiante_universitario : Estudiante 
    {
        public int nivelculmunado;
        public int matriculaanual;
        
        public Estudiante_universitario(int nivelculmunado, int matriculaanual)
        {
            this.nivelculmunado = nivelculmunado;
            this.matriculaanual = matriculaanual
        }
        public int Matricula;
        int preciocredito;

        public void datos_de_estudiante()
        {
            Console.WriteLine("Nombre"+ Nombre);
            Console.WriteLine("Apellido"+ Apellido);
            Console.WriteLine("Nombre de institucion educativa" + Institucion);
            Console.WriteLine("Numero de cedula" + Cedula);
            Console.WriteLine("Precio de credito $7");
            Console.WriteLine("Cantidad de creditos"+ calculo_matricula)

        }

        public void matricula()
        {
        int operacion;
        valorfinal = nivelculmunado *matriculaanual ;
        Console.WriteLine("La Matricula del estudiante universitario a pagar es");
        Console.WriteLine("cantidad de creditos"+nivelculmunado);
        Console.WriteLine("el calculo final es "+ valorfinal);

        }
    }
}