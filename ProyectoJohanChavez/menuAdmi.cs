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
    public partial class menuAdmi : Form
    {
        public menuAdmi()
        {
            InitializeComponent();
        }

        private void menuAdmi_Load(object sender, EventArgs e)
        {


        }

        private void buttonCalcularSueldo_Click(object sender, EventArgs e)
        {
            CalcularSueldo calcular = new CalcularSueldo();
            this.Hide();
            calcular.Show();
        }

        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            registrarUsuario registrar=new registrarUsuario();
            this.Hide();
            registrar.Show();

        }
    }
}
