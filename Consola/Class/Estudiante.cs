using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public class Estudiante
    { 
       //public string Nombre { get; set; } //propiedad autoimplementada para almacenar el nombre del estudiante

        private string nombre= string.Empty;//campo privado para almacenar el nombre del estudiante

        public string Nombre //propiedad para acceder al campo privado nombre
        {
            get { return nombre.ToUpper(); }
            set { nombre = value; }
        }

        public string Domicilio { get; set; } = string.Empty;

        public int Edad { get; set; }

        //creamos una propiedad llamada DatosPersonales que concatena todos los datos del estudiante y devuelva al llamarla
        public string DatosPersonales
        {
            get
            {
                return $"Nombre: {Nombre}\nDomicilio: {Domicilio}\nEdad: {Edad}";
            }

        }  

        public void Saludar()
            {
                Console.WriteLine($"Hola, soy el estudiante {this.Nombre} y tengo {this.Edad} años");
            }
        
    }
}
