using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoJohanChavez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IsMdiContainer = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuAdmin.Visible = false;
            menuUser.Visible = false;
            menuEmpleado.Visible = false;
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dadwasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void activarUser()
        {
            menuUser.Visible = true;
        }

        private void calcularSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcularSueldo from = new CalcularSueldo();
            from.MdiParent = this;

            from.Show();
            from.WindowState = FormWindowState.Maximized;
        }

        private void buttonOmitir_Click(object sender, EventArgs e)
        {

        }

        private void buttonOmitir_Click_1(object sender, EventArgs e)
        {
            menuUser.Visible = true;
            groupInicioSesion.Visible = false;
        }
    }
}
