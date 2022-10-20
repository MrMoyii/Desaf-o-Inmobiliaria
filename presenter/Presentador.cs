using Desafio_Herencia_1_.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Herencia_1_.presenter
{
    class Presentador
    {
        private IView view;

        public Presentador(IView view)
        {
            this.view = view;
            ArrayList arr = new ArrayList();
            arr = view.GetInputValues();

            if (!Validacion(arr[0], "string"))
            {
                view.DisplayResult("Error", true, "Ingrese una direccion.");
                return;
            }
            if (!Validacion(arr[1], "int"))
            {
                view.DisplayResult("Error", true, "Ingrese un número de m2 valido.");
                return;
            }
            if (!Validacion(arr[2], "int"))
            {
                view.DisplayResult("Error", true, "Ingrese un precio base valido.");
                return;
            }

            //si se Chequeo el local comercial
            if (bool.Parse(arr[6].ToString()))
            {
                if (!Validacion(arr[4], "int"))
                    view.DisplayResult("Error", true, "Ingrese un número de ventanas valido.");
                else
                {
                    //creacion del modelo
                    LocalComercial lComercial = new LocalComercial();

                    lComercial.cantVentas = int.Parse(arr[4].ToString());
                    AlamacenarDatos(lComercial, ref arr);
                    CalcularYEnviarDatos(lComercial, ref view);
                }
            }
            else //se chequeo el piso
            {
                if (!Validacion(arr[3], "int"))
                    view.DisplayResult("Error", true, "Ingrese un número de piso valido.");
                else
                {
                    //creacion del modelo
                    Piso piso = new Piso();

                    piso.numeroDePiso = int.Parse(arr[3].ToString());
                    AlamacenarDatos(piso, ref arr);
                    CalcularYEnviarDatos(piso, ref view);
                }
            }
        }

        public static void CalcularYEnviarDatos(Inmobiliaria obj, ref IView view)
        {
            double resultado = obj.calcularPrecio();
            view.DisplayResult(resultado.ToString(), false, "No paso nada jeje");
        }

        public static void AlamacenarDatos(Inmobiliaria obj, ref ArrayList arr)
        {
            obj.direccion = arr[0].ToString();
            obj.m2 = int.Parse(arr[2].ToString());
            obj.esNuevo = bool.Parse(arr[5].ToString());
            obj.precioBase = int.Parse(arr[2].ToString());
        }

        public static bool Validacion(object dato, string tipoDato)
        {
            switch (tipoDato)
            {
                case "int":
                    return int.TryParse(dato.ToString(), out _);

                case "string":

                    if (string.IsNullOrEmpty(dato.ToString().Trim()))
                        return false;
                    else
                        return true;

                default:
                    return false;
            }
        }
    }
}
