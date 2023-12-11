using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CE_CapaEntidades;
using MySqlConnector;
using ProyectoJohanChavez;
using CE_CapaEntidades;
using CL_Controlador;

namespace ProyectoJohanChavez
{


    public partial class PanelUsuario : Form
    {
        public string documento;
        public PanelUsuario()
        {
            InitializeComponent();

        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void PanelUsuario_Load(object sender, EventArgs e)
        {

        }

        



        public static Form1 form1=new Form1();
        public static String CadenaConexion = "Server=localhost; DATABASE=trabajadores; UID=root; PASSWORD=";
        public MySqlConnection conexion = new MySqlConnection(CadenaConexion);


        public static string img = "SELECT imagen FROM usuario WHERE noDocumento='" + form1.documento + "'";

        public static string docum = form1.documento;
     
        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = "1122";
            CE_CapaEntidades.CE_Usuario objUsuario= new CE_Usuario();
            objUsuario.noDocumento= int.Parse(label10.Text);
            DataTable dt= new DataTable();
            dt= CT_Usuario.CTconsultarImagen(objUsuario);
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][0]);
            Bitmap bm = new Bitmap(ms);
            pictureBox1.Image = bm;
        }

    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonRiesgos_Click(object sender, EventArgs e)
        {
            CL_Controlador.CT_Usuario.CTInsertarImagen();
        }
    }
}
