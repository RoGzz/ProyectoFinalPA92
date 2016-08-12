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
        bool validar;

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

        private void EditarUsuario()
        {
            db.cmd.CommandText = ("UPDATE tblusuarios SET user = '" + txtUsuario.Text + "', password = '" + txtContrasena.Text + "', type = '" + getTipo(comboBoxTipoCuenta.SelectedItem.ToString()) + "' WHERE id_u = '" + txtID.Text + "'");
            db.cmd.Connection = db.conn;
            if (db.conn.State == 0)
                db.conn.Open();
            db.cmd.ExecuteNonQuery();
            db.conn.Close();
            MessageBox.Show("Usuario actualizado con exito");
        }

        private void EliminarUsuario()
        {
            db.cmd.CommandText = ("DELETE FROM tblusuarios WHERE id_u ='" + txtID.Text + "' ");
            db.cmd.Connection = db.conn;
            if (db.conn.State == 0)
                db.conn.Open();
            db.cmd.ExecuteNonQuery();
            db.conn.Close();
            MessageBox.Show("Usuario eliminado con exito");
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
            txtID.Clear();
            txtUsuario.Clear();
            txtContrasena.Clear();
            txtVerifContra.Clear();
            comboBoxTipoCuenta.Text = "";
            txtUsuario.Focus();
        }

        private void cargarDatos()
        {
            db.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_u, user, password, type  FROM tblusuarios order by id_u", db.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            db.conn.Close();
            dt.Dispose();
        }

        private void cargarUser()
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells[0].Value);
                db.cmd.CommandText = "SELECT * from tblusuarios WHERE id_u = '" + a + "'";
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataSet ds = new DataSet();
                db.cmd.Connection = db.conn;
                if (db.conn.State == 0)
                    db.conn.Open();
                db.cmd.ExecuteNonQuery();
                da.SelectCommand = db.cmd;
                da.Fill(ds, "tblusuarios");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtID.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
                    txtUsuario.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                    txtContrasena.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
                    comboBoxTipoCuenta.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                }
                db.conn.Close();

            }
        }

        

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void bttnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtContrasena.Text != txtVerifContra.Text)
                {
                    MessageBox.Show("La contraseña no concuerda", "Error de verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    string ope = groupBox1.Text;
                    switch (ope)
                    {
                        case "Agregar":
                            AgregarUsuario();
                            break;
                        case "Editar":
                            EditarUsuario();
                            cargarDatos();
                            break;
                        case "Eliminar":
                            EliminarUsuario();
                            cargarDatos();
                            break;
                    }
                    LimpiarCampos();
                }
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

       
        private void toolStripButtonEliminar_Click(object sender, EventArgs e)
        {
            cargarDatos();
            groupBox1.Text = "Eliminar";
            dataGridView1.Enabled = true;
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            cargarUser();
        }

        

        private void toolStripButtonAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            groupBox1.Text = "Agregar";
            dataGridView1.Enabled = false;
            dataGridView1.SelectAll();
            dataGridView1.ClearSelection();
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            cargarDatos();
            groupBox1.Text = "Editar";
            dataGridView1.Enabled = true;
           
        }
    }
}
