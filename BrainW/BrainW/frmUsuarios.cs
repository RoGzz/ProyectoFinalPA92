using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace BrainW
{
    public partial class frmUsuarios : Form
    {
        dbConn db = new dbConn();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        public int getTipo(string _tipo)
        {
            int tipo = 0;
            if (_tipo == "Usuario")
                tipo = 1;
            return tipo;
        }



        private void AgregarUsuario()
        {
            if (txtContrasena.Text == txtVerifContra.Text)
            {
                db.cmd.CommandText = ("INSERT INTO tblusuarios (user, password, type) VALUES ('" + txtUsuario.Text + "','" + txtContrasena.Text + "','" + getTipo(comboBoxTipoCuenta.SelectedItem.ToString()) + "')");
                db.cmd.Connection = db.conn;
                if (db.conn.State == 0)
                    db.conn.Open();
                db.cmd.ExecuteNonQuery();
                db.conn.Close();
                MessageBox.Show("Usuario registrado con exito");
            }
            else
                MessageBox.Show("Las contraseñas no coinciden");
        }

        private void EditarUsurio()
        {
            db.cmd.CommandText = ("UPDATE tblusuario SET user = '" + txtUsuario.Text + "', password = '" + txtContrasena.Text + "', nivel = '" + getTipo(comboBoxTipoCuenta.SelectedItem.ToString()) + "' WHERE id_u = '" + dataGridView1.SelectedCells + "')");
            db.cmd.Connection = db.conn;
            if (db.conn.State == 0)
                db.conn.Open();
            db.cmd.ExecuteNonQuery();
            db.conn.Close();
            MessageBox.Show("Usuario actualizado con exito");
        }

        private void Eliminar()
        {
            db.cmd.CommandText = ("DELETE FROM tblusuario WHERE id_u ='" + dataGridView1.SelectedCells + "' ");
            db.cmd.Connection = db.conn;
            if (db.conn.State == 0)
                db.conn.Open();
            db.cmd.ExecuteNonQuery();
            db.conn.Close();
            MessageBox.Show("Usuario actualizado con exito");
        }

        private void verifContra()
        {
            
            pictureBox1.Visible = true;
            if (txtVerifContra.Text == txtContrasena.Text)

                pictureBox1.Image = Properties.Resources.Ok;
            else
                pictureBox1.Image = Properties.Resources.Error;
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtVerifContra.Clear();
            comboBoxTipoCuenta.Text = "";
            txtUsuario.Focus();
        }

        private void cargarDatos()
        {
            db.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_u, user FROM tblusuarios order by id_u", db.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            db.conn.Close();
            dt.Dispose();
        }

        private void cargarUser()
        {
            db.cmd.CommandText = "SELECT * from tblusuarios WHERE id_u = '" + dataGridView1.SelectedCells.ToString() + "'";
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            db.cmd.Connection = db.conn;
            if (db.conn.State == 0)
                db.conn.Open();
            db.cmd.ExecuteNonQuery();
            da.SelectCommand = db.cmd;
            da.Fill(ds,"tblusuarios");
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtID.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                txtUsuario.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                txtContrasena.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                comboBoxTipoCuenta.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            }
            db.conn.Close();

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarDatos();

        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarUsuario();
                cargarDatos();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void toolStripButtonAgregar_CheckStateChanged(object sender, EventArgs e)
        {
            if (toolStripButtonAgregar.Checked == false)
            {
                toolStripButtonEditar.Checked = false;
                toolStripButtonEliminar.Checked = false;
                toolStripButtonAgregar.Checked = true;
            }
        }

        private void txtVerifContra_TextChanged(object sender, EventArgs e)
        {
            verifContra();
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            verifContra();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarUser();
        }
    }
}
