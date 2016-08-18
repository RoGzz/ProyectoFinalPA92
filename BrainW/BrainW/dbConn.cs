using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace BrainW
{    
    class dbConn
    {
        public static string stringconnection = "Database=pfpa92; DataSource=localhost; Uid=root; pwd=1234";
        //public MySqlConnection conn = new MySqlConnection(stringconnection);
        public MySqlConnection conn = new MySqlConnection(stringconnection);
        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter adapter = new MySqlDataAdapter();
        public DataSet dataset = new DataSet();
        
    }
}
