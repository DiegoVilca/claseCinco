using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using claseTres;

namespace claseTresFormUI
{
    public partial class Form1 : Form
    {

        private carrera miCarrera;
        private auto miAuto;
        


        public Form1()
        {
            InitializeComponent();


            //Forma para cargar combos a partir de un enumerado
            foreach (eFabricante item in Enum.GetValues(typeof (eFabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }

            //Datos para test

            this.txtFecha.Text = "13/09/16";
            this.txtLugar.Text = "Avellaneda";
            this.txtNombre.Text = "Diego";
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //rueda miRueda = new rueda();
            miCarrera = new carrera(this.txtNombre.Text, this.txtFecha.Text, this.txtLugar.Text);

            this.gpbCarrera.Enabled = false;
            
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            miAuto = new auto(this.txtNombrePiloto.Text, (eFabricante)this.cmbFabricante.SelectedItem);
            miCarrera = miCarrera + miAuto;

            CargarListado();
        }


        private void CargarListado()
        {
            this.lbsListado.Items.Clear();

            foreach (auto item in this.miCarrera.ListaAutos)
            {
                
                this.lbsListado.Items.Add(item.DatosEnString);
            }
        }


    }
}
