using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAVD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Usuario_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void Login_Contrasena_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void Login_Continuar_Click(object sender, EventArgs e)
        {
            var NuevoForm = new Hoteles();
            NuevoForm.Show();
        }
    }

}
