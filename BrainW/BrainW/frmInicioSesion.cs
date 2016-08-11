using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BrainW
{
    public partial class frmInicioSesion : Form
    {
        dbConn dbConn = new dbConn();
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void login()
        {
            try
            {
                dbConn.cmd.Connection =dbConn.conn;
                if (dbConn.conn.State == 0)
                    dbConn.conn.Open();
                dbConn.cmd.CommandText = "SELECT user, password, type FROM tblusuarios WHERE user = '" + txtB_Usuario.Text + "' && password = '" + txtB_Contraseña.Text + "'";
                MySqlDataReader leer = dbConn.cmd.ExecuteReader();
                
                if (leer.Read())
                {
                    this.Visible = false;
                    frmMenu menu = new frmMenu();
                    menu.userToolStripMenuItem.Text = txtB_Usuario.Text;
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtB_Usuario.Clear();
                    txtB_Contraseña.Clear();
                    txtB_Usuario.Focus();
                }
                dbConn.conn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void FRM_InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void bttn_Aceptar_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
