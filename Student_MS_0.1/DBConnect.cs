using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Student_MS_0._1
{
    public partial class DBConnect : Component
    {
        /*public DBConnect()
        {
            //to create connection
            MySqlConnection connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=studentdb");

        //to get connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }

        //create a function to Open conncetion
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //Create a fuction to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }*/
    
    }
}
