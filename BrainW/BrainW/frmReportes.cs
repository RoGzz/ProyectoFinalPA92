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
    public partial class frmReportes : Form
    {
        dbConn db = new dbConn();

        public frmReportes()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
            db.conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT u.user, s.date, score.score FROM tblusuarios as u INNER JOIN tblsesiones as s ON s.id_u = u.id_u left JOIN tblscores as score on score.id_l = s.id_l;", db.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            db.conn.Close();
            dt.Dispose();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
           
            cargarDatos();
        }

        



    }
}
