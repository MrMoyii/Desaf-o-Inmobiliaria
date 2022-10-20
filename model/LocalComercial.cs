using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Herencia_1_.model
{
    class LocalComercial : Inmobiliaria
    {
        public LocalComercial() : base()
        {

        }

        public int cantVentas { get; internal set; }

        public override double calcularPrecio()
        {
            double ventanas = (cantVentas <= 1) ? -(precioBase * 1d / 100d) : (cantVentas > 4) ? (precioBase * 2d / 100d) : 0;
            double metros = (m2 > 50) ? precioBase * 1d / 100d : 0;
            return precioBase - base.calcularPrecio() + ventanas + metros;
        }
    }
}
