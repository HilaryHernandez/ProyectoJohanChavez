namespace ProyectoJohanChavez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuEmpleado = new System.Windows.Forms.MenuStrip();
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.menuUser = new System.Windows.Forms.MenuStrip();
            this.calcularSueldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupInicioSesion = new System.Windows.Forms.GroupBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.buttonOmitir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContraseñaInicioSesion = new System.Windows.Forms.TextBox();
            this.IdentificaciónInicioSesion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuUser.SuspendLayout();
            this.groupInicioSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuEmpleado
            // 
            this.menuEmpleado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuEmpleado.Location = new System.Drawing.Point(0, 52);
            this.menuEmpleado.Name = "menuEmpleado";
            this.menuEmpleado.Size = new System.Drawing.Size(1067, 24);
            this.menuEmpleado.TabIndex = 0;
            this.menuEmpleado.Text = "menuAdmin";
            // 
            // menuAdmin
            // 
            this.menuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAdmin.Location = new System.Drawing.Point(0, 28);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(1067, 24);
            this.menuAdmin.TabIndex = 1;
            this.menuAdmin.Text = "menuUser";
            // 
            // menuUser
            // 
            this.menuUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularSueldoToolStripMenuItem});
            this.menuUser.Location = new System.Drawing.Point(0, 0);
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(1067, 28);
            this.menuUser.TabIndex = 2;
            this.menuUser.Text = "menuEmpleado";
            // 
            // calcularSueldoToolStripMenuItem
            // 
            this.calcularSueldoToolStripMenuItem.Name = "calcularSueldoToolStripMenuItem";
            this.calcularSueldoToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.calcularSueldoToolStripMenuItem.Text = "Calcular Sueldo";
            this.calcularSueldoToolStripMenuItem.Click += new System.EventHandler(this.calcularSueldoToolStripMenuItem_Click);
            // 
            // groupInicioSesion
            // 
            this.groupInicioSesion.Controls.Add(this.buttonIngresar);
            this.groupInicioSesion.Controls.Add(this.buttonOmitir);
            this.groupInicioSesion.Controls.Add(this.pictureBox1);
            this.groupInicioSesion.Controls.Add(this.ContraseñaInicioSesion);
            this.groupInicioSesion.Controls.Add(this.IdentificaciónInicioSesion);
            this.groupInicioSesion.Controls.Add(this.label4);
            this.groupInicioSesion.Controls.Add(this.label3);
            this.groupInicioSesion.Location = new System.Drawing.Point(5, 7);
            this.groupInicioSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupInicioSesion.Name = "groupInicioSesion";
            this.groupInicioSesion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupInicioSesion.Size = new System.Drawing.Size(1061, 503);
            this.groupInicioSesion.TabIndex = 3;
            this.groupInicioSesion.TabStop = false;
            this.groupInicioSesion.Text = "Inicio de sesion";
            this.groupInicioSesion.Enter += new System.EventHandler(this.groupInicioSesion_Enter_1);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonIngresar.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIngresar.ForeColor = System.Drawing.Color.Azure;
            this.buttonIngresar.Location = new System.Drawing.Point(536, 439);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(135, 54);
            this.buttonIngresar.TabIndex = 51;
            this.buttonIngresar.Text = "INGRESAR";
            this.buttonIngresar.UseVisualStyleBackColor = false;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click_1);
            // 
            // buttonOmitir
            // 
            this.buttonOmitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOmitir.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOmitir.ForeColor = System.Drawing.Color.Azure;
            this.buttonOmitir.Location = new System.Drawing.Point(388, 439);
            this.buttonOmitir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOmitir.Name = "buttonOmitir";
            this.buttonOmitir.Size = new System.Drawing.Size(135, 54);
            this.buttonOmitir.TabIndex = 50;
            this.buttonOmitir.Text = "OMITIR";
            this.buttonOmitir.UseVisualStyleBackColor = false;
            this.buttonOmitir.Click += new System.EventHandler(this.buttonOmitir_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoJohanChavez.Properties.Resources.usuario__5_;
            this.pictureBox1.Location = new System.Drawing.Point(439, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 156);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // ContraseñaInicioSesion
            // 
            this.ContraseñaInicioSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContraseñaInicioSesion.Location = new System.Drawing.Point(388, 351);
            this.ContraseñaInicioSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContraseñaInicioSesion.Name = "ContraseñaInicioSesion";
            this.ContraseñaInicioSesion.Size = new System.Drawing.Size(279, 22);
            this.ContraseñaInicioSesion.TabIndex = 48;
            // 
            // IdentificaciónInicioSesion
            // 
            this.IdentificaciónInicioSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdentificaciónInicioSesion.Location = new System.Drawing.Point(385, 251);
            this.IdentificaciónInicioSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdentificaciónInicioSesion.Name = "IdentificaciónInicioSesion";
            this.IdentificaciónInicioSesion.Size = new System.Drawing.Size(279, 22);
            this.IdentificaciónInicioSesion.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 320);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 46;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 45;
            this.label3.Text = "Identificación";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1067, 654);
            this.Controls.Add(this.menuEmpleado);
            this.Controls.Add(this.menuAdmin);
            this.Controls.Add(this.menuUser);
            this.Controls.Add(this.groupInicioSesion);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuUser.ResumeLayout(false);
            this.menuUser.PerformLayout();
            this.groupInicioSesion.ResumeLayout(false);
            this.groupInicioSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEmpleado;
        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.MenuStrip menuUser;
        private System.Windows.Forms.ToolStripMenuItem calcularSueldoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupInicioSesion;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonOmitir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ContraseñaInicioSesion;
        public  System.Windows.Forms.TextBox IdentificaciónInicioSesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

