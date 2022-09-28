using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }

        private void PantallaLogin_Load(object sender, EventArgs e)
        {
            this.cboEncriptacion.SelectedIndex = 0;
            //this.btnEncriptar.Enabled = false;
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private void btoCerrar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            System.GC.Collect();
        }

        

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (this.cboEncriptacion.SelectedItem.Equals("MD5"))
            {
                if (this.txtUser.Text.Equals("gil") && this.txtPassword.Text.Equals("e99a18c428cb38d5f260853678922e03"))
                {
                    MessageBox.Show("Bienvenido");
                }
                else
                {
                    MessageBox.Show("Usuario o conraseñas incorrectos!");
                }
            }
            if (this.cboEncriptacion.SelectedItem.Equals("SHA512"))
            {
                if (this.txtUser.Text.Equals("gil") && this.txtPassword.Text.Equals("c70b5dd9ebfb6f51d09d4132b7170c9d20750a7852f00680f65658f0310e810056e6763c34c9a00b0e940076f54495c169fc2302cceb312039271c43469507dc"))
                {
                    MessageBox.Show("Bienvenido");
                }
                else
                {
                    MessageBox.Show("Usuario o conraseñas incorrectos!");
                }
            }
            if (this.cboEncriptacion.SelectedItem.Equals("CHACHA20"))
            {
                    if (this.txtUser.Text.Equals("gil") && this.txtPassword.Text.Equals("3B-2A-79-52-51-01"))
                {
                    MessageBox.Show("Bienvenido");
                }
                else
                {
                    MessageBox.Show("Usuario o conraseñas incorrectos!");
                }
            }

            //SHA512 = c70b5dd9ebfb6f51d09d4132b7170c9d20750a7852f00680f65658f0310e810056e6763c34c9a00b0e940076f54495c169fc2302cceb312039271c43469507dc
            //MD5 = e99a18c428cb38d5f260853678922e03
            //CHACHA20 = 3B-2A-79-52-51-01
        }

        private void cboEncriptacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
