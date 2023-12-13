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
        public registrarUsuario()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            //CARGA DE IMAGEN A BYTE PARA DESPUES PASARLO A LA BASE DE DATOS
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Png);
            
            byte[] aByte = ms.ToArray();


            CE_Usuario usuario=new CE_Usuario();
            usuario.tipoDocumento=comboBoxDocumento.SelectedItem as string;
            usuario.noDocumento=int.Parse(noDocumento.Text);
            usuario.nombre = nombre.Text;
            usuario.apellido=apellido.Text;
            usuario.direccion=direccion.Text;
            usuario.correo=correo.Text;
            usuario.telefono=int.Parse(telefono.Text);
            usuario.cargo=cargo.Text;
            usuario.nivelRiesgo = comboBoxNivelRiesgo.SelectedIndex + 1;
            usuario.contraseña=contraseña.Text;
            usuario.rol = comboBoxRol.SelectedIndex + 1;
            usuario.imagen = aByte;

            CL_Controlador.CT_Usuario.CTRegistrarUsuario(usuario);
            MessageBox.Show("REGISTRO EXITOSO");

            

        }




        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir=new OpenFileDialog();
            abrir.Filter = "Imagenes|*.jpg; *.png";
            abrir.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            abrir.Title = "Seleccionar imagen";

            if(abrir.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(abrir.FileName);
            }
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
