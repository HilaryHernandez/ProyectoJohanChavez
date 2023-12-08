using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Controlador;


namespace ProyectoJohanChavez
{
    public partial class CalcularSueldo : Form
    {
        public CalcularSueldo()
        {
            InitializeComponent();
        }

        public ComboBox cb
        {
            get { return cbTipoTrabajador; }
            set { cbTipoTrabajador=value;}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CalcularSueldo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            labelIBC.Text =CTCalcularSueldo.CalcularIbc(int.Parse(txtSueldo.Text), int.Parse(txtHorasExtra.Text))+"";

            labelSueldo.Text = txtSueldo.Text;
            labelHorasExtra.Text = txtHorasExtra.Text;
            labelDiasTrabajados.Text = txtDiasTrabajados.Text;
            labelNivelRiesgoSSE.Text = cbNivelRiesgo.Text;
            labelTipoTrabajador.Text = cbTipoTrabajador.Text;
            labelPensionSSE.Text = CTCalcularSueldo.CalcularPension(int.Parse(labelIBC.Text))+"";
            labelArlSSE.Text = CTCalcularSueldo.CalcularArl(double.Parse(labelIBC.Text),labelNivelRiesgoSSE.Text);
            labelEpsSSE.Text =CTCalcularSueldo.CalcularEps(int.Parse(labelIBC.Text));
            if (labelTipoTrabajador.Text.Equals("INDEPENDIENTE"))
            {
                labelCajaCompensacionAP.Text = "0";
                labelIcbfAP.Text = "0";
                labelSenaAP.Text= "0";
            }
            else
            {
                labelCajaCompensacionAP.Text = CTCalcularSueldo.CalcularCajaCompensacion(int.Parse(labelSueldo.Text));
                labelIcbfAP.Text = CTCalcularSueldo.CalcularICBF(int.Parse(labelSueldo.Text)); ;
                labelSenaAP.Text = CTCalcularSueldo.CalcularSENA(int.Parse(labelSueldo.Text)); ;
            }
        }

        private void groupCalcular_Enter(object sender, EventArgs e)
        {

        }
    }
}
