using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Services
{
    class DBHelper2
    {
        /*private MySqlConnection myConnection;
        private static string connectionString = "server=127.0.0.1;uid=root;password=null;database=LibraryInfoManageDB";
        myConnection = new MySqlConnection(myConnectionString);
        //open a connection
        myConnection.Open();

        // create a MySQL command and set the SQL statement with parameters
        MySqlCommand myCommand = new MySqlCommand();
        myCommand.Connection = myConnection;
        myCommand.CommandText = @"SELECT * FROM clients WHERE client_id = @clientId;";
        myCommand.Parameters.AddWithValue("@clientId", clientId);

        // execute the command and read the results
        using var myReader = myCommand.ExecuteReader()
        {
            while (myReader.Read())
            {   
                var id = myReader.GetInt32("client_id");
                var name = myReader.GetString("client_name");
                // ...
             }
        }
        myConnection.Close();*/
    }
}
