using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edad_mayor_o_menor
{
    class Persona
    {
        //Atributos de la clase persona 
        private string nombre;
        private int edad;
        //Método
        public void Edades()
        {
            //Declaramos los atributos
            Console.WriteLine("Ingrese el nombre");
            //Método para introducir una cadena de texto por la consola
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad");
            //Método para introducir un valor de tipo entero por la consola
            edad = Convert.ToInt32(Console.ReadLine());
            //Condición que evalúa el atributo edad 
            if (edad >= 18)
            {
                Console.WriteLine(nombre + " es mayor de edad");
            }
            else
            {
                Console.WriteLine(nombre + " es menor de edad");
            }
            Console.ReadLine();
        }
    }
}
