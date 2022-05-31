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
            string Nom;
            StreamWriter sw = new StreamWriter("Ejemplo.txt", true);
            //si el archivo no existe lo creara
            //si ya existe, escribira en el

            Console.Write("Ingresa un nombre: ");
            Nom = Convert.ToString(Console.ReadLine());

            string[] Lines ={
                Nom

            };

            foreach (string Line in Lines)
            {
                sw.WriteLine(Line);
            }
            sw.Close();//se debe cerrare el archivo

            Console.WriteLine("Escrbiendo en el archivo.....");
            Console.ReadLine();
        }
    }
}
