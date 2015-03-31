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
    public partial class frmData : Form
    {
       
        public frmData()
        {
            InitializeComponent();
            
        }

        private void frmData_Load(object sender, EventArgs e)
        {
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            string cs = @"Server =75.185.65.213; Port =3306; Database =test; Uid =root; Pwd =7hat9gegessen;";
            connection = new MySqlConnection(cs);
            try
            {
                connection.Open();
                MessageBox.Show("Connection Established");
                //
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SHOW TABLES;";
                MySqlDataReader Reader;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        row += Reader.GetValue(i).ToString() + ", ";
                    MessageBox.Show(row);

                }
                connection.Close();
                connection.Open();
                MySqlCommand command2 = connection.CreateCommand();
                command2.CommandText = "select lastname, email from usersystem;";
                //myCommand.CommandText = "What?";
                MySqlDataReader Reader2;
                Reader2 = command2.ExecuteReader();
                while (Reader2.Read())
                {
                    string row2 = "";
                    for (int i = 0; i < Reader2.FieldCount; i++)
                        row2 += Reader2.GetValue(i).ToString() + ", ";
                    MessageBox.Show(row2);
                }
                connection.Close();
                //
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("There was a problem connecting...");
            }
        }

        private void btnCustomConnect_Click(object sender, EventArgs e)
        {
            string ServerAddress = txt1ServerAddress.Text;
            string PortNumber = txt2PortNumber.Text;
            string Database = txt3Database.Text;
            string Username = txt4Username.Text;
            string Password = txt5Password.Text;
            string cs2 = @"Server =" + ServerAddress + "; Port =" + PortNumber + "; Database =" + Database + "; Uid =" + Username + "; Pwd =" + Password + ";";
            MessageBox.Show(cs2);
            MySqlConnection connection2;
            connection2 = new MySqlConnection(cs2);
            try
            {
                connection2.Open();
                MessageBox.Show("Connection Established");
                //
                MySqlCommand command = connection2.CreateCommand();
                command.CommandText = "SHOW TABLES;";
                MySqlDataReader Reader;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    string row = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                        row += Reader.GetValue(i).ToString() + ", ";
                    MessageBox.Show(row);

                }
                connection2.Close();
                connection2.Open();
                MySqlCommand command2 = connection2.CreateCommand();
                command2.CommandText = "select lastname, email from usersystem;";
                //myCommand.CommandText = "What?";
                MySqlDataReader Reader2;
                Reader2 = command2.ExecuteReader();
                while (Reader2.Read())
                {
                    string row2 = "";
                    for (int i = 0; i < Reader2.FieldCount; i++)
                        row2 += Reader2.GetValue(i).ToString() + ", ";
                    MessageBox.Show(row2);
                }
                connection2.Close();
                //
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("shit");
            }
        }

        }
    }
