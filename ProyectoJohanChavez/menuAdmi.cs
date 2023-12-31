﻿using System;
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
        int doc;
        public menuAdmi()
        {
            InitializeComponent();
        }

        public int documento
        {
            get { return doc; }
            set { doc = value; }
        }

        private void menuAdmi_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalcularSueldo_Click(object sender, EventArgs e)
        {
            CalcularSueldo calcular = new CalcularSueldo();
            calcular.tip = 1;
            calcular.textbox = doc;
            this.Hide();
            calcular.Show();
        }

        private void menuAdmi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
        }

        private void buttonRegistrarUsuario_Click(object sender, EventArgs e)
        {
            registrarUsuario registrar = new registrarUsuario();
            registrar.textbox = int.Parse(doc.ToString());
            this.Hide();
            registrar.Show();
        }

        private void buttonActualizarDatos_Click(object sender, EventArgs e)
        {
            modificarDatos mod = new modificarDatos();
            mod.textbox = doc;
            this.Hide();
            mod.Show();
        }

        private void buttonConsultarUsuario_Click(object sender, EventArgs e)
        {
            PanelUsuario panelUsuario = new PanelUsuario();
            panelUsuario.datagrid.Visible = true;
            panelUsuario.textbox = doc;
            panelUsuario.tip = 1;
            panelUsuario.Show();
            this.Hide();
        }
    }
}
