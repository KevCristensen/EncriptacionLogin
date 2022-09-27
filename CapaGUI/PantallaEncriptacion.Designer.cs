namespace CapaGUI
{
    partial class PantallaEncriptacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaEncriptacion));
            this.cboEncriptacion = new System.Windows.Forms.ComboBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btoCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEncriptacion
            // 
            this.cboEncriptacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncriptacion.FormattingEnabled = true;
            this.cboEncriptacion.Items.AddRange(new object[] {
            "MD5",
            "SHA512",
            "CHACHA20"});
            this.cboEncriptacion.Location = new System.Drawing.Point(139, 24);
            this.cboEncriptacion.Margin = new System.Windows.Forms.Padding(2);
            this.cboEncriptacion.Name = "cboEncriptacion";
            this.cboEncriptacion.Size = new System.Drawing.Size(92, 21);
            this.cboEncriptacion.TabIndex = 13;
            this.cboEncriptacion.SelectedIndexChanged += new System.EventHandler(this.cboEncriptacion_SelectedIndexChanged);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(66, 130);
            this.btnEncriptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(67, 19);
            this.btnEncriptar.TabIndex = 12;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(139, 78);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(104, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // btoCerrar
            // 
            this.btoCerrar.Location = new System.Drawing.Point(166, 130);
            this.btoCerrar.Name = "btoCerrar";
            this.btoCerrar.Size = new System.Drawing.Size(65, 19);
            this.btoCerrar.TabIndex = 14;
            this.btoCerrar.Text = "Cerrar";
            this.btoCerrar.UseVisualStyleBackColor = true;
            this.btoCerrar.Click += new System.EventHandler(this.btoCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tipo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaEncriptacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 227);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btoCerrar);
            this.Controls.Add(this.cboEncriptacion);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Name = "PantallaEncriptacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEncriptacion;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btoCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

