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
        int tipo=0;
        DataTable dt = new DataTable();
        public PanelUsuario()
        {
            InitializeComponent();


        }

        public int tip
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public DataGridView datagrid
        {
            get { return dataGridView1; }
            set { dataGridView1 = value; }
        }

        public TextBox textbox
        {
            get { return textBoxDocumento; }
            set { textBoxDocumento = value; }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void PanelUsuario_Load(object sender, EventArgs e)
        {
            
            dt = CT_Usuario.CTConsultarUsuario();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            DataGridViewButtonColumn colum = new DataGridViewButtonColumn();
            colum.Name = "Seleccionar";
            colum.Text = "Seleccionar";
            dataGridView1.Columns.Add(colum);
            DataTable dt2 = new DataTable();
            dt2 = CT_Usuario.CTConsultarUsuarioPorDocumento(int.Parse(textBoxDocumento.Text));
            textBoxTipoDocumento.Text = dt2.Rows[0][2].ToString();
            textBoxNombres.Text = dt2.Rows[0][3].ToString();
            textBoxApellidos.Text = dt2.Rows[0][4].ToString();
            textBoxDireccion.Text = dt2.Rows[0][5].ToString();
            textBoxTelefono.Text = dt2.Rows[0][6].ToString();
            textBoxCorreo.Text = dt2.Rows[0][7].ToString();
            textBoxCargo.Text = dt2.Rows[0][8].ToString();
            textBoxNivelRiesgo.Text = dt2.Rows[0][9].ToString();
            try
            {
                MemoryStream ms2 = new MemoryStream((byte[])dt.Rows[0][10]);
                Bitmap bm2 = new Bitmap(ms2);
                pictureBox1.Image = bm2;
            }
            catch (SystemException ex)
            {
                pictureBox1.Image = null;
            }
            textBoxContraseña.Text = dt2.Rows[0][11].ToString();
            if (int.Parse(dt2.Rows[0][12].ToString())== 1)
            {
                comboBoxRol.SelectedIndex = 0;
            }
            else
            {
                comboBoxRol.SelectedIndex = 1;
            }
        }

        


     
        private void button1_Click(object sender, EventArgs e)
        {

            CE_CapaEntidades.CE_Usuario objUsuario= new CE_Usuario();
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
            
        }

        private void buttonActualizarU_Click(object sender, EventArgs e)
        {
            CE_Usuario objUsuario = new CE_Usuario();
            objUsuario.noDocumento =int.Parse (textBoxDocumento.Text);
            objUsuario.telefono =int.Parse(textBoxTelefono.Text);
            objUsuario.direccion =textBoxDireccion.Text;
            objUsuario.correo =textBoxCorreo.Text;
            objUsuario.contraseña =textBoxContraseña.Text;
            if (CT_Usuario.CTActualizarUsuario(objUsuario))
            {
                MessageBox.Show("Actualizacion correcta");
            }
            else
            {
                MessageBox.Show("Error en la actualizacion");
            }
        }

        private void PanelUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (tipo == 1)
            {
                menuAdmi form = new menuAdmi();
                form.Show();
            }
            else
            {
                menu form = new menu();
                form.Show();
            }
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Seleccionar")
            {
                dataGridView1.Visible = false;

                textBoxTipoDocumento.Text = dataGridView1[2,e.RowIndex].Value.ToString();
                textBoxNombres.Text = dataGridView1[3, e.RowIndex].Value.ToString();
                textBoxApellidos.Text = dataGridView1[4, e.RowIndex].Value.ToString();
                textBoxDireccion.Text = dataGridView1[5, e.RowIndex].Value.ToString();
                textBoxTelefono.Text = dataGridView1[6, e.RowIndex].Value.ToString();
                textBoxCorreo.Text = dataGridView1[7, e.RowIndex].Value.ToString();
                textBoxCargo.Text = dataGridView1[8, e.RowIndex].Value.ToString();
                textBoxNivelRiesgo.Text = dataGridView1[9, e.RowIndex].Value.ToString();
                try
                {
                    MemoryStream ms2 = new MemoryStream((byte[])dt.Rows[e.RowIndex][10]);
                    Bitmap bm2 = new Bitmap(ms2);
                    pictureBox1.Image = bm2;
                }
                catch(SystemException ex)
                {
                    pictureBox1.Image = null;
                }
                textBoxContraseña.Text = dataGridView1[11, e.RowIndex].Value.ToString();
                if (int.Parse(dataGridView1[12, e.RowIndex].Value.ToString()) == 1)
                {
                    comboBoxRol.SelectedIndex = 0;
                }
                else
                {
                    comboBoxRol.SelectedIndex = 1;
                }
            }
        }
    }
}
