using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class DB
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=pizza");


        public void openConnection()
        {
/*            if(conn.State == System.Data.ConnectionState.Closed)
            {*/
                conn.Open();
/*            }*/
        }


        public void closeConnection()
        {
          /*  if (conn.State == System.Data.ConnectionState.Open)
            {*/
                conn.Close();
            /*}*/
        }


        public MySqlConnection ConnectToMysql()
        {
            return conn;
        }
    }
}
