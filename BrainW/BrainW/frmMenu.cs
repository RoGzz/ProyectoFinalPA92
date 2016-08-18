using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainW
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        public void ChildCleaner()
        {
            for (int cc = 0; cc < this.MdiChildren.Length; cc++)
            {
                this.MdiChildren[cc].Close();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildCleaner();
            frmUsuarios users = new frmUsuarios();
            users.MdiParent = this;
            users.Show();
        
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmacercaDe version = new frmacercaDe();
            version.MdiParent = this;
            version.Show();

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildCleaner();
            frmReportes report = new frmReportes();
            report.MdiParent = this;
            report.Show();
        }
    }
}
