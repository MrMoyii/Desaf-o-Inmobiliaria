using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Herencia_1_.model
{
    abstract class Inmobiliaria
    {
        public string direccion { get; internal set; }
        public int m2 { get; internal set; }
        public bool esNuevo { get; internal set; }
        public int precioBase { get; internal set; }


        public virtual double calcularPrecio()
        {
            //devuelve la antiguedad
            return (esNuevo == true) ? (precioBase * 1d / 100d) : (precioBase * 2d / 100d);
        }
    }
}
