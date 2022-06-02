using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Escritura_archivos
{
    internal class Program
    {
        class Registro_Empleo
        {
            public string nombre;
            public string apellidos;
            public string domilicio;
            public string RFC;

            //constructor
            public Registro_Empleo(string nombre, string apellidos, string domicilio, string RFC)
            {
                this.nombre = nombre;
                this.apellidos = apellidos;
                this.domilicio = domicilio;
                this.RFC = RFC;
            }
        }
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //si el archivo no existe lo creará
            //si ya existe, escribirá en él
            //true es para agregar y no para sobreescribir

            string nombre, apellidos, domicilio, RFC;


            Console.Write("Ingrese un nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese sus apellidos: ");
            apellidos = Console.ReadLine();

            Console.Write("Ingrese su domicilio: ");
            domicilio = Console.ReadLine();

            Console.Write("Ingresa su RFC: ");
            RFC = Console.ReadLine();

            Registro_Empleo Persona = new Registro_Empleo(nombre, apellidos, domicilio, RFC);

            sw.WriteLine(Persona.nombre + "  " + Persona.apellidos + "  " + Persona.domilicio + "  " + Persona.RFC);

            sw.Close(); //Siempre se debe cerrar el archivo

            Console.WriteLine("Escribiendo en el archivo.........");
            Console.ReadLine();
        }
    }
}
