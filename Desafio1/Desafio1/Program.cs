using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("Android", "Samsung");
           
            
            Console.WriteLine("El modelo es " + t1.modelo);
            Console.WriteLine("La marca del celular es: " + t1.marca);
            Console.WriteLine("Ingrese el codigo de operador");
            t1.CodigoOperador = int.Parse(Console.ReadLine());
            Console.WriteLine("El codigo de operador es: " + t1.CodigoOperador);
            Console.WriteLine("Ingrese el numero telefonico: ");
            t1.NumeroTelefonico=Console.ReadLine();
            Console.WriteLine("Ingrese el nombre contacto:");
            t1.Contacto=Console.ReadLine();
            Console.WriteLine(t1.Llamar());
            Console.ReadKey();  
        }
    }
}
