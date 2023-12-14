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
    public partial class modificarDatos : Form
    {
        int doc = 0;
        public modificarDatos()
        {
            InitializeComponent();
        }

        public int textbox
        {
            get { return doc; }
            set { doc = value; }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void modificarDatos_Load(object sender, EventArgs e)
            {
                DataTable dt = new DataTable();
                dt = CT_Variables.CTconsultarVariables();

                salarioMinimo.Text = dt.Rows[0]["porcentaje"].ToString();
                epsEmpresa.Text = dt.Rows[1]["porcentaje"].ToString();
                epsEmpleado.Text = dt.Rows[2]["porcentaje"].ToString();
                epsIndependiente.Text = dt.Rows[3]["porcentaje"].ToString();
                pensionEmpresa.Text = dt.Rows[4]["porcentaje"].ToString();
                pensionEmpleado.Text = dt.Rows[5]["porcentaje"].ToString();
                pensionIndependiente.Text = dt.Rows[6]["porcentaje"].ToString();
                arlClase1.Text = dt.Rows[7]["porcentaje"].ToString();
                arlClase2.Text = dt.Rows[8]["porcentaje"].ToString();
                arlClase3.Text = dt.Rows[9]["porcentaje"].ToString();
                arlClase4.Text = dt.Rows[10]["porcentaje"].ToString();
                arlClase5.Text = dt.Rows[11]["porcentaje"].ToString();
            }
        private void button1_Click(object sender, EventArgs e)
        {
            if(CT_Variables.CTactualizarVariables("SueldoMinimo", salarioMinimo.Text))
            {
                MessageBox.Show("Actualización exitosa");
                
            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("EpsEmpresa", epsEmpresa.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("EpsEmpleado", epsEmpleado.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("EpsIndependiente", epsIndependiente.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("PensionEmpresa", pensionEmpresa.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("PensionEmpleado", pensionEmpleado.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("PensionIndependiente", pensionIndependiente.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("ArlClase1", arlClase1.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("ArlClase2", arlClase2.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("ArlClase3", arlClase3.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("ArlClase4", arlClase4.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CT_Variables.CTactualizarVariables("ArlClase5", arlClase5.Text))
            {
                MessageBox.Show("Actualización exitosa");

            }
            else
            {
                MessageBox.Show("Actualización fallida");
            }
        }

        private void modificarDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuAdmi admin = new menuAdmi();
            admin.documento = doc;
            admin.Show();
        }
    }
}
