using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MySqlConnector;
using static ProyectoJohanChavez.PanelUsuario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using CL_Controlador;
using MySql.Data.MySqlClient;
using System.Data;

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
            
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dadwasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void activarUser()
        {
            
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
            //menuUser.Visible = true;
            //groupInicioSesion.Visible = false;

            CalcularSueldo calcular = new CalcularSueldo();
            this.Hide();
            calcular.cb.SelectedIndex = 0;
            calcular.cb.Enabled = false;
            calcular.Show();

            //modificarDatos mod = new modificarDatos();
            //this.Hide();
            //mod.Show();
        }

        private void groupInicioSesion_Enter(object sender, EventArgs e)
        {

        }



        public static String CadenaConexion = "Server=localhost; DATABASE=trabajadores; UID=root; PASSWORD=";
        public MySql.Data.MySqlClient.MySqlConnection conexion = new MySql.Data.MySqlClient.MySqlConnection(CadenaConexion);
        public string documento;
        

        private void buttonIngresar_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=CT_Usuario.CTConsultarLogin(IdentificaciónInicioSesion.Text, ContraseñaInicioSesion.Text);
            if (dt.Rows.Count > 0)
            {
                if (int.Parse(dt.Rows[0][12].ToString()) == 1)
                {

                    menuAdmi menuadmi = new menuAdmi();
                    menuadmi.documento = int.Parse(IdentificaciónInicioSesion.Text);
                    menuadmi.Show();
                    this.Hide();
                }
                else if (int.Parse(dt.Rows[0][12].ToString()) == 2)
                {
                    menu menu = new menu();
                    menu.doc = int.Parse(IdentificaciónInicioSesion.Text);
                    menu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            
        }

        

        private void groupInicioSesion_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
