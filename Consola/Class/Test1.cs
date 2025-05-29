using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public class Test1
    {
        private double _precio;
        private string _nombre;
        public Test1(double precio, string nombre )
        {
            _precio = precio;
            _nombre = nombre;
            var fecha = DateTime.Now;

            Mostrar();
            var fechaNow =fechaMostrar();
            Console.WriteLine($"La fecha es: {fechaNow}");
        }

        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        private string fechaMostrar()
        {
            var fecha = DateTime.Now;
            return fecha.ToString();
        }
        void Mostrar()
        {
            Console.WriteLine($"El precio es: {_precio}");
            Console.WriteLine($"El nombre es: {_nombre}");
        }
    }
}
