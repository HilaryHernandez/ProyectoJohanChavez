using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CE_CapaEntidades;

namespace ProyectoJohanChavez
{
    public partial class registrarUsuario : Form
    {
        int doc = 0;
        public registrarUsuario()
        {
            InitializeComponent();
        }

        public int textbox
        {
            get { return doc; }
            set { doc = value; }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
           


            CE_Usuario usuario=new CE_Usuario();
            usuario.tipoDocumento=comboBoxDocumento.SelectedItem as string;
            usuario.noDocumento=int.Parse(noDocumento.Text);
            usuario.nombre = nombre.Text;
            usuario.apellido=apellido.Text;
            usuario.direccion=direccion.Text;
            usuario.correo=correo.Text;
            usuario.telefono=telefono.Text;
            usuario.cargo=cargo.Text;
            usuario.nivelRiesgo = comboBoxNivelRiesgo.SelectedIndex + 1;
            usuario.contraseña=contraseña.Text;
            usuario.rol = cbRol.SelectedIndex + 1;
            if (CL_Controlador.CT_Usuario.CTRegistrarUsuario(usuario))
            {
                MessageBox.Show("REGISTRO EXITOSO");
                nombre.Text = "";
                noDocumento.Text = "";
                apellido.Text = "";
                direccion.Text = "";
                correo.Text = "";
                telefono.Text = "";
                noDocumento.Text = "";
                cargo.Text = "";
                contraseña.Text = "";
                comboBoxDocumento.SelectedIndex = 0;
                comboBoxNivelRiesgo.SelectedIndex = 0;
                cbRol.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error en el registro");
            }
            

            

        }




        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void registrarUsuario_Load(object sender, EventArgs e)
        {
            comboBoxDocumento.SelectedIndex = 0;
            comboBoxNivelRiesgo.SelectedIndex = 0;
            cbRol.SelectedIndex = 0;
        }

        private void registrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuAdmi menuadmi = new menuAdmi();
            menuadmi.documento = int.Parse(doc.ToString());
            menuadmi.Show();
        }
    }
}
