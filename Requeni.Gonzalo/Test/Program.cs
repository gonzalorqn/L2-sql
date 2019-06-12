using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos ad = new AccesoDatos();
            List<Persona> lista = ad.TraerTodos();
            foreach (Persona item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Persona p = new Persona(2, "Rodrigo", "Perez", 62);
            if (ad.AgregarPersona(p))
                Console.WriteLine("Se agrego correctamente");
            Console.ReadLine();
        }
    }
}
