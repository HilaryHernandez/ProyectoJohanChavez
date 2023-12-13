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
    public partial class registrarUsuario : Form
    {
        public registrarUsuario()
        {
            InitializeComponent();
        }

        private void registrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuAdmi admin = new menuAdmi();
            this.Hide();
            admin.Show();
        }

        private void registrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
