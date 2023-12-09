using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

            from.cb.SelectedIndex = 0;
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

        private void groupInicioSesion_Enter(object sender, EventArgs e)
        {

        }

        public static String CadenaConexion = "Server=localhost; DATABASE=trabajadores; UID=root; PASSWORD=";
        MySqlConnection conexion = new MySqlConnection(CadenaConexion);
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string validacion = "select * from usuario WHERE noDocumento='" + IdentificaciónInicioSesion.Text + "' and contraseña='" + ContraseñaInicioSesion.Text + "'";
            MySqlCommand comando = new MySqlCommand(validacion, conexion);
            MySqlDataReader lector = comando.ExecuteReader();

            if (IdentificaciónInicioSesion.Text == string.Empty || ContraseñaInicioSesion.Text == string.Empty)
            {
                MessageBox.Show("Los campos deben estar llenos");
            }
            else if (lector.HasRows==true) 
            {
                menu menu = new menu();
                this.Hide();
                menu.Show();

            }
            else
            {
                MessageBox.Show("DOCUMENTO O CONTRRASEÑA INCORRECTOS");
            }
            conexion.Close();
        }
    }
}
