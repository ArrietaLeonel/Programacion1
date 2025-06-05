using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public class Calculadora
    {
        private double _numero1;
        private double _numero2;
        public static int instancias;
        public Calculadora(double numero1, double numero2)
        {
            instancias++;
            _numero1 = numero1;
            _numero2 = numero2;
        }
        public double Sumar()
        {
            return _numero1 + _numero2;
        }
        public double Restar()
        {
            return _numero1 - _numero2;
        }
        public double Multiplicar()
        {
            return _numero1 * _numero2;
        }
        public double Dividir()
        {
            if (_numero2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir entre cero.");
            }
            return _numero1 / _numero2;
        }

    }
}
