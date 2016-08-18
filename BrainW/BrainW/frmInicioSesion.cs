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
        public static int id_u;
        

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void login()
        {
            
            try
            {
                dbConn.cmd.Connection = dbConn.conn;
                if (dbConn.conn.State == 0)
                    dbConn.conn.Open();
                dbConn.cmd.CommandText = "SELECT id_u, user, password, type FROM tblusuarios WHERE user = '" + txtB_Usuario.Text + "' && password = '" + txtB_Contraseña.Text + "'";
                MySqlDataReader dato = dbConn.cmd.ExecuteReader();
                
                if (dato.Read())
                {
                    dbConn.conn.Close();
                    dbConn.conn.Open();
                    dbConn.cmd.ExecuteNonQuery();
                    dbConn.adapter.SelectCommand = dbConn.cmd;
                    dbConn.adapter.Fill(dbConn.dataset, "tblusuarios");
                    id_u = int.Parse(dbConn.dataset.Tables[0].Rows[0].ItemArray[0].ToString());
                    dbConn.conn.Close();
                    dbConn.cmd.CommandText = "iNSERT INTO tblsesiones (id_u, date) VALUES('" + id_u + "','" + DateTime.Now.ToString() + "')";
                    dbConn.conn.Open();
                    dbConn.cmd.ExecuteNonQuery();
                    //MessageBox.Show(id_u.ToString());
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
