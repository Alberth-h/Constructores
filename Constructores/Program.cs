using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "Alberto";
            contacto1.Celular = "6664206913";
            contacto1.Correo = "aa59@correo.com";

            Console.WriteLine("Contacto 1:");
            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Celular: " + contacto1.Celular);
            Console.WriteLine("Correo: " + contacto1.Correo);
            Console.WriteLine("Direccion: " + contacto1.Direccion);

            Contacto contacto2 = new Contacto("Jesus", "yisus@correo.com");

            Console.WriteLine("Contacto 2:");
            Console.WriteLine("Nombre:" + contacto2.Nombre);
            Console.WriteLine("Correo:" + contacto2.Correo);
            Console.WriteLine("Direccion:" + contacto2.Direccion);

            Console.Read();
        }
    }
}