using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Herencia_1_.presenter
{
    interface IView
    {
        void DisplayResult(string result, bool error, string quePaso);
        ArrayList GetInputValues();
    }
}
