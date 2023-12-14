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
        int tipo = 0;
        int doc = 0;
        public CalcularSueldo()
        {
            InitializeComponent();
        }

        public int textbox
        {
            get { return doc; }
            set { doc = value; }
        }

        public ComboBox cb
        {
            get { return cbTipoTrabajador; }
            set { cbTipoTrabajador=value;}
        }

        public int tip
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CalcularSueldo_Load(object sender, EventArgs e)
        {
            CTCalcularSueldo.datos();
            cbNivelRiesgo.SelectedIndex = 0;
            cbTipoTrabajador.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            
            labelIBC.Text =CTCalcularSueldo.CalcularIbc(int.Parse(txtSueldo.Text), int.Parse(txtHorasExtra.Text))+"";

            labelSueldo.Text = CTCalcularSueldo.calcularSueldoConHorasExtras(int.Parse(txtSueldo.Text),int.Parse(txtHorasExtra.Text));
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
                labelCesantiasPS.Text = "0";
                labelVacacionesPS.Text = "0";
                labelInteresCesantiasPS.Text = "0";
                labelPensionSST.Text = CTCalcularSueldo.CalcularPensionIndependiente(int.Parse(labelSueldo.Text));
                labelEpsSST.Text = CTCalcularSueldo.CalcularEpsIndependiente(int.Parse(labelSueldo.Text));
                labelPrima.Text = "0";
                labelLiquidacion.Text = "0";
                labelSueldoTotal.Text = (int.Parse(labelSueldo.Text) - (int.Parse(labelPensionSST.Text) + int.Parse(labelEpsSST.Text))).ToString();
            }
            else if (labelTipoTrabajador.Text.Equals("EMPLEADO"))
                {            
                //Seguridad social Empresa
                labelPensionSSE.Text = CTCalcularSueldo.CalcularPension(int.Parse(labelIBC.Text)) + "";
                labelArlSSE.Text = CTCalcularSueldo.CalcularArl(double.Parse(labelIBC.Text), labelNivelRiesgoSSE.Text);
                labelEpsSSE.Text = CTCalcularSueldo.CalcularEps(int.Parse(labelIBC.Text));
                //Aportes parafiscales 
                labelCajaCompensacionAP.Text = CTCalcularSueldo.CalcularCajaCompensacion(int.Parse(labelSueldo.Text));
                labelIcbfAP.Text = CTCalcularSueldo.CalcularICBF(int.Parse(labelSueldo.Text)); 
                labelSenaAP.Text = CTCalcularSueldo.CalcularSENA(int.Parse(labelSueldo.Text));
                //Prestaciones sociales
                labelCesantiasPS.Text = CTCalcularSueldo.calcularCesantias(int.Parse(labelSueldo.Text),int.Parse(labelDiasTrabajados.Text));
                labelVacacionesPS.Text = CTCalcularSueldo.calcularVacaciones(int.Parse(labelSueldo.Text), int.Parse(labelDiasTrabajados.Text));
                labelInteresCesantiasPS.Text = CTCalcularSueldo.calcularInteresesCesantias(double.Parse(labelCesantiasPS.Text), double.Parse(labelDiasTrabajados.Text));
                labelPensionSST.Text =CTCalcularSueldo.CalcularPensionEmpleado(int.Parse(labelSueldo.Text));
                labelEpsSST.Text =CTCalcularSueldo.CalcularEpsEmpleado(int.Parse(labelSueldo.Text));
                //prima y liquidacion
                labelPrima.Text = CTCalcularSueldo.CalcularPrima(int.Parse(labelSueldo.Text), int.Parse(labelDiasTrabajados.Text));
                labelLiquidacion.Text= CTCalcularSueldo.CalcularLiquidacion(int.Parse(labelSueldo.Text), int.Parse(labelDiasTrabajados.Text));
                labelSueldoTotal.Text = (int.Parse(labelSueldo.Text) - (int.Parse(labelPensionSST.Text) + int.Parse(labelEpsSST.Text))).ToString();
            }
        }

        private void groupCalcular_Enter(object sender, EventArgs e)
        {

        }

        private void CalcularSueldo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tipo == 1)
            {
                menuAdmi form = new menuAdmi();
                form.documento = int.Parse(doc.ToString());
                form.Show();
            }
            else if (tipo==2)
            {
                menu form = new menu();
                form.documento = int.Parse(doc.ToString());
                form.Show();
            }
            else
            {
                Form1 form = new Form1();
                form.documento = doc.ToString();
                form.Show();
            }
        }

        private void labelSueldo_Click(object sender, EventArgs e)
        {

        }
    }
}
