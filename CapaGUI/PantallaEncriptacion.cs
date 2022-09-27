using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace CapaGUI
{
    public partial class PantallaEncriptacion : Form
    {
        public PantallaEncriptacion()
        {
            InitializeComponent();
        }

        public string EncriptarMD5(string password) 
        {
            var msgBytes = Encoding.ASCII.GetBytes(password);
            var md = new MD5Cng();
            var nuevoHash = md.ComputeHash(msgBytes);
  
            System.Text.StringBuilder resultado = new System.Text.StringBuilder();
            foreach (byte b in nuevoHash)
            {
                resultado.Append(b.ToString("x2"));
            }

            return Convert.ToString(resultado); 
        }

        public String EncriptarSHA512(string password)
        {
            var msgBytes = Encoding.ASCII.GetBytes(password);

            var sha = new SHA512Managed();
            var hash = sha.ComputeHash(msgBytes);
            System.Text.StringBuilder resultado = new System.Text.StringBuilder();
            foreach (byte b in hash)
            {
                resultado.Append(b.ToString("x2"));
            }

            return Convert.ToString(resultado);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cboEncriptacion.SelectedIndex = 0;
            //this.btnEncriptar.Enabled = false;
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private void btoCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        private void btnEncriptar_Click_1(object sender, EventArgs e)
        {
            if (this.cboEncriptacion.SelectedItem.Equals("MD5"))
            {
                MessageBox.Show(EncriptarMD5(this.txtPassword.Text), "Contraseña en MD5");
            }
            if (this.cboEncriptacion.SelectedItem.Equals("SHA512"))
            {
                MessageBox.Show(EncriptarSHA512(this.txtPassword.Text), "Contraseña en SHA512");
            }
        }
    }
}
