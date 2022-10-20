using Desafio_Herencia_1_.presenter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Herencia_1_
{
    public partial class Form1 : Form, IView
    {
        Presentador presentador;
        public Form1()
        {
            InitializeComponent();
            txtPiso.Enabled = true;
            txtVentanas.Enabled = false;
        }

        //actualiza los valores del display 
        public void DisplayResult(string result, bool error, string quePaso)
        {
            //si hay un error lo muestro
            if (error)
                MessageBox.Show(quePaso, result);
            else
                txtPrecioCalculado.Text = result;
        }

        //da los valores del input
        public ArrayList GetInputValues()
        {
            //retora los valores de los input
            ArrayList arr = new ArrayList();
            arr.Add(txtDireccion.Text);      //0                 obligatorio validiar
            arr.Add(txtM2.Text);             //1                 obligatorio validiar
            arr.Add(txtPrecioBase.Text);     //2 precioBase      obligatorio validiar
            arr.Add(txtPiso.Text);           //3                 este campo se valida si se eligio piso
            arr.Add(txtVentanas.Text);       //4                 este campo se valida si se eligio local comercial
            arr.Add(Nuevo.Checked);          //5
            arr.Add(LocalComercial.Checked); //6
            return arr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presentador = new Presentador(this);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtPiso.Enabled = true;
            txtVentanas.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtPiso.Enabled = false;
            txtVentanas.Enabled = true;
        }
    }
}
