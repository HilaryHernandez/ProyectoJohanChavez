﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CL_Controlador;


namespace ProyectoJohanChavez
{
    public partial class CalcularSueldo : Form
    {
        public CalcularSueldo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CalcularSueldo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            labelIBC.Text = CL_Controlador.CalcularSueldo.CalcularIbc(int.Parse(txtSueldo.Text), int.Parse(txtHorasExtra.Text))+"";

            labelSueldo.Text = txtSueldo.Text;
            labelHorasExtra.Text = txtHorasExtra.Text;
            labelDiasTrabajados.Text = txtDiasTrabajados.Text;
            labelNivelRiesgoSSE.Text = cbNivelRiesgo.Text;
            labelTipoTrabajador.Text = cbTipoTrabajador.Text;

            
        }
    }
}