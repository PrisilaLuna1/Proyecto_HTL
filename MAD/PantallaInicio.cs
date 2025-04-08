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
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void AbrirControlEnPanel(UserControl control)
        {
            panelContenedor.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(control);
            control.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_TEST_Click(object sender, EventArgs e)
        {
            //AbrirControlEnPanel(new User_Controls.UserControl1());
        }

        private void BTN_OPCIONES_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 250)
            {
                PanelMenu.Width = 70;
                LOGO_CISNE.Width = 50;
                LOGO_CISNE.Height = 50;
            }
            else {
                PanelMenu.Width = 250;
                LOGO_CISNE.Width = 202;
                LOGO_CISNE.Height = 165;
            }
        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_Reportes_Click(object sender, EventArgs e)
        {
            AbrirControlEnPanel(new User_Controls.UserControl1());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelContenedorFondo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
