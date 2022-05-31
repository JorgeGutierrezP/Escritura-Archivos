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
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //si el archivo no existe lo creará
            //y si existe escribirá en el

            string[] lines =
            {
                "Esta es la nueva escritura",
                "Esta es la segunda linea",
                "fin del texto"
            };  
            foreach(string line in lines)
            {
                sw.WriteLine(lines);
            }
            sw.Close(); //siempre se debe cerrar el archivo
            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadLine();
        }
    }
}
