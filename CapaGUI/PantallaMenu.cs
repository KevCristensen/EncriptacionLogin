using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class PantallaMenu : Form
    {
        public PantallaMenu()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void encriptaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PantallaEncriptacion pEncriptacion = new PantallaEncriptacion();
            pEncriptacion.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PantallaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
