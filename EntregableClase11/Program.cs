using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregableClase11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Usuario> listado = UsuarioADO.ObtenerTodosLosUsuarios();


            Console.WriteLine("Termine");

        }
    }
}
