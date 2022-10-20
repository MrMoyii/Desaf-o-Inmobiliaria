using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Herencia_1_.model
{
    class Piso : Inmobiliaria
    {
        public Piso() : base()
        {
        }
        public int numeroDePiso { get; internal set; }

        public override double calcularPrecio()
        {
            double prefPiso = (numeroDePiso >= 3) ? precioBase * 3d / 100d : 0;
            return precioBase - base.calcularPrecio() + prefPiso;
        }
    }
}
