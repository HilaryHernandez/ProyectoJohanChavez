namespace ProyectoJohanChavez
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalcularSueldo = new System.Windows.Forms.Button();
            this.buttonPanelUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalcularSueldo
            // 
            this.buttonCalcularSueldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCalcularSueldo.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcularSueldo.ForeColor = System.Drawing.Color.Azure;
            this.buttonCalcularSueldo.Location = new System.Drawing.Point(216, 263);
            this.buttonCalcularSueldo.Name = "buttonCalcularSueldo";
            this.buttonCalcularSueldo.Size = new System.Drawing.Size(151, 55);
            this.buttonCalcularSueldo.TabIndex = 0;
            this.buttonCalcularSueldo.Text = "CALCULAR SUELDO";
            this.buttonCalcularSueldo.UseVisualStyleBackColor = false;
            this.buttonCalcularSueldo.Click += new System.EventHandler(this.buttonCalcularSueldo_Click);
            // 
            // buttonPanelUsuario
            // 
            this.buttonPanelUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPanelUsuario.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPanelUsuario.ForeColor = System.Drawing.Color.Azure;
            this.buttonPanelUsuario.Location = new System.Drawing.Point(436, 263);
            this.buttonPanelUsuario.Name = "buttonPanelUsuario";
            this.buttonPanelUsuario.Size = new System.Drawing.Size(151, 55);
            this.buttonPanelUsuario.TabIndex = 1;
            this.buttonPanelUsuario.Text = "PANEL DE USUARIO";
            this.buttonPanelUsuario.UseVisualStyleBackColor = false;
            this.buttonPanelUsuario.Click += new System.EventHandler(this.buttonPanelUsuario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(295, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SELECCIONE UNA OPCIÓN:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoJohanChavez.Properties.Resources.presupuesto;
            this.pictureBox2.Location = new System.Drawing.Point(261, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 61);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoJohanChavez.Properties.Resources.datos_del_usuario;
            this.pictureBox1.Location = new System.Drawing.Point(480, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 61);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPanelUsuario);
            this.Controls.Add(this.buttonCalcularSueldo);
            this.Name = "menu";
            this.Text = "menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menu_FormClosed);
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcularSueldo;
        private System.Windows.Forms.Button buttonPanelUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}