using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var NuevoForm = new Reservaciones();
            NuevoForm.Show();
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NuevoForm = new Hoteles();
            NuevoForm.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NuevoForm = new Usuario();
            NuevoForm.Show();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NuevoForm = new Clientes();
            NuevoForm.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NuevoForm = new Reportes();
            NuevoForm.Show();
        }
    }
}
