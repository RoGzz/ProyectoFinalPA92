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
        public string stringconnection = "Database=pfpa92; DataSource=localhost; Uid=root; pwd=1234";
        public MySqlCommand cmd = new MySqlCommand();

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void login()
        {
            try
            {

                MySqlConnection conn = new MySqlConnection(stringconnection);
                cmd.Connection = conn;
                if (conn.State == 0)
                    conn.Open(); 
                cmd.CommandText = "SELECT user, password, type FROM tblusuarios WHERE user = '" + txtB_Usuario.Text + "' && password = '" + txtB_Contraseña.Text + "'";
                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    this.Visible = false;
                    frmMenu menu = new frmMenu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtB_Usuario.Clear();
                    txtB_Contraseña.Clear();
                    txtB_Usuario.Focus();
                }
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
