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
    public partial class FRM_InicioSesion : Form
    {
        public string stringconnection = "Database=pfpa92; DataSource=localhost; Uid=root; pwd=1234";
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter adapter = new MySqlDataAdapter();
        public DataSet dataset = new DataSet();

        public FRM_InicioSesion()
        {
            InitializeComponent();
        }

        private void login()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(stringconnection);
                cmd.CommandText = "SELECT id_u, user, password, type FROM tblusuarios";
                cmd.Connection = conn;
                if (conn.State == 0)
                    conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset, "tblusuarios");
                if (dataset.Tables[0].Rows.Count > 0)
                {
                    for (int rowC = 0; rowC < dataset.Tables[0].Rows.Count; rowC++)
                    {
                        if (txtB_Usuario.Text == dataset.Tables[0].Rows[rowC].ItemArray[1].ToString() && txtB_Contraseña.Text == dataset.Tables[0].Rows[rowC].ItemArray[2].ToString())
                        {
                            this.Visible = false;
                            frmMenu menu = new frmMenu();
                            menu.Show();
                            break;
                        }
                        else
                        {
                            if (rowC == dataset.Tables[0].Rows.Count - 1)
                            {
                                MessageBox.Show("Usuario/Contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtB_Usuario.Clear();
                                txtB_Contraseña.Clear();
                                txtB_Usuario.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message);
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
