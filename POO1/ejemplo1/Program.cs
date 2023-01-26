using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro();
            Console.WriteLine("Ingrese el nombre del perro: ");
            p1.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el color del perro: ");
            p1.Color=Console.ReadLine();
            Console.WriteLine("Ingrese el origen del perro: ");
            p1.Origen = Console.ReadLine();

            Console.WriteLine("El nombre del perro es " + p1.Nombre);
            Console.WriteLine("El color es " + p1.Color);
            Console.WriteLine("El origen es " + p1.Origen);
            Console.ReadKey();


        }   
    }
}
