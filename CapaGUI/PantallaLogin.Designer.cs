namespace CapaGUI
{
    partial class PantallaLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.btoCerrar = new System.Windows.Forms.Button();
            this.cboEncriptacion = new System.Windows.Forms.ComboBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tipo";
            // 
            // btoCerrar
            // 
            this.btoCerrar.Location = new System.Drawing.Point(222, 162);
            this.btoCerrar.Name = "btoCerrar";
            this.btoCerrar.Size = new System.Drawing.Size(65, 19);
            this.btoCerrar.TabIndex = 23;
            this.btoCerrar.Text = "Cerrar";
            this.btoCerrar.UseVisualStyleBackColor = true;
            this.btoCerrar.Click += new System.EventHandler(this.btoCerrar_Click_1);
            // 
            // cboEncriptacion
            // 
            this.cboEncriptacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEncriptacion.FormattingEnabled = true;
            this.cboEncriptacion.Items.AddRange(new object[] {
            "MD5",
            "SHA512"});
            this.cboEncriptacion.Location = new System.Drawing.Point(136, 11);
            this.cboEncriptacion.Margin = new System.Windows.Forms.Padding(2);
            this.cboEncriptacion.Name = "cboEncriptacion";
            this.cboEncriptacion.Size = new System.Drawing.Size(92, 21);
            this.cboEncriptacion.TabIndex = 22;
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(122, 162);
            this.btnEncriptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(67, 19);
            this.btnEncriptar.TabIndex = 21;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(40, 162);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(56, 19);
            this.btnIngresar.TabIndex = 20;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(136, 98);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(104, 20);
            this.txtPassword.TabIndex = 19;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(136, 55);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(104, 20);
            this.txtUser.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario";
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 205);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btoCerrar);
            this.Controls.Add(this.cboEncriptacion);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaLogin";
            this.Text = "PantallaLogin";
            this.Load += new System.EventHandler(this.PantallaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btoCerrar;
        private System.Windows.Forms.ComboBox cboEncriptacion;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}