using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Arduino
{
    public class DBcontrol
    {
                public string QueryData(MySqlConnection  c)
                {
                    string output = "";
                    //string row2 = "";
                    c.Close();
                    c.Open();
                    MySqlCommand command2 = c.CreateCommand();
                    command2.CommandText = "select status_onORoff from carcommands where status_connection = \"4\";";
                    MySqlDataReader Reader2;
                  
                    Reader2 = command2.ExecuteReader();
                    if (Reader2.Read())
                    {
                        output = Reader2[0].ToString();
                        
                    }
                    return (output);
                    //c.Close();
                    //
            }
            
        }
}
   
