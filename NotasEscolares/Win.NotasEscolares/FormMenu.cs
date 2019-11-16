using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.NotasEscolares
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void examenesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void primerParcialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formExamen = new FormEspañol();
            formExamen.MdiParent = this;
            formExamen.Show();
        }

        private void examenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMatematicas = new FormMatematicas();
            formMatematicas.MdiParent = this;
            formMatematicas.Show();
        }

        private void notaTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formIngles = new FormIngles();
            formIngles.MdiParent = this;
            formIngles.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }
    }
}
