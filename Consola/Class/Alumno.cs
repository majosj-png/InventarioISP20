using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public partial class Alumno
    {
        static int instamcias_de_alumnos = 0; //variable estatica para contar la cantidad de instancias de la clase alumno
        string nombre;
        string apellido;
        int dni;
        DateOnly fechaNacimiento;

        //constructor de la clase alumno
        public Alumno(string nombre, string apellido, int dni, DateOnly fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;

            instamcias_de_alumnos++; //incrementamos la cantidad de instancias cada vez que se crea un nuevo alumno

        }

        //metodo para imprimir la ficha de datos del alumno
        public string ImpresionFichaDeDatos()
        {
            return $"Nombre: {nombre} {apellido}\n DNI: {dni}\n Fecha de Nacimiento: {fechaNacimiento}";

        }

       
    }
}
