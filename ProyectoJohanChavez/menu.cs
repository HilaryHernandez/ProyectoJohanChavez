using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Xml.Linq;
using DocumentFormat.OpenXml.EMMA;

namespace ProyectoJohanChavez
{
    public partial class menu : Form
    {

        public menu()
        {
            InitializeComponent();

            
            
        }
        Form1 form1;
        PanelUsuario panelUsuario=new PanelUsuario();


        
        private void buttonPanelUsuario_Click(object sender, EventArgs e)
        {

            
            panelUsuario.Show();



        }
    }
}
