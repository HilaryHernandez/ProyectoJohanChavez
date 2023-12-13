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
        public int doc;
        public menu()
        {
            InitializeComponent();

            
            
        }
        Form1 form1;
        

        public int documento
        {
            get { return doc; }
            set { doc = value; }
        }

        private void buttonPanelUsuario_Click(object sender, EventArgs e)
        {
            PanelUsuario panelUsuario = new PanelUsuario();
            panelUsuario.datagrid.Visible = false;
            panelUsuario.textbox.Text = doc.ToString();
            panelUsuario.Show();
            this.Hide();


        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void buttonCalcularSueldo_Click(object sender, EventArgs e)
        {
            CalcularSueldo calcular = new CalcularSueldo();
            this.Hide();
            calcular.cb.SelectedIndex = 1;
            calcular.cb.Enabled = false;
            calcular.tip = 2;
            calcular.Show();
        }
    }
}
