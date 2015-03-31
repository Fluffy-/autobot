using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Threading;
using System.Management;

namespace Arduino
{
    public partial class frmMain : Form
    {
        //string array for com ports
        string[] comPorts;
        DBcontrol DBread;
        MySqlConnection connection;
        Color clrBackColor;
        Color green = Color.Green;
        Color red = Color.Red;
        Boolean preparingToClosePorts = false;
        public static String myValue = "";
        public String mytext = "";


        public frmMain()
        {
            InitializeComponent();

            //Clear status strip
            lblCurrentActivity.Text = " ... ";
            lblSerialStatus.Text = " ... ";
            lblDBStatus.Text = " ... ";
            lblICStatus.Text = " ... ";
            lblTouchStatus.Text = " ... ";
            // Make sure proper buttons are disabled
            btnHideCluster.Enabled = false;
            btnStopCommunication.Enabled = false;
            button1.Enabled = false;

            DBread = new DBcontrol();

            //Link serial port data_received event
            srlArduino.DataReceived += srlArduino_DataReceived;

            //Link serial port pin change event
            srlArduino.PinChanged += srlArduino_PinChanged;
        }

        void srlArduino_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
           //implement later - Handle pin change.
        }

        void srlArduino_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
                //Write Data to Output

            // If the com port has been closed, do nothing
            if (!srlArduino.IsOpen) { return; }

            string data = srlArduino.ReadExisting();

            rtfSerialOutput.Invoke(new EventHandler(delegate
            {
                String hello = DBread.QueryData(connection);
                
                if(data != "\n")
                {
                    
                    rtfSerialOutput.SelectedText = string.Empty;
                    rtfSerialOutput.SelectionFont = new Font(rtfSerialOutput.SelectionFont, FontStyle.Bold);
                    rtfSerialOutput.AppendText(data + " ");



                    // This section is used to test the interations
                    // between the serial input and the instrument cluster
                    if(data == "ON")
                    {
                        String myString = data.ToString();
                        myForm.SetTextForLabel(myString);
                    }
                    else if (data == "OFF")
                    {
                        String myString = data.ToString();
                        myForm.SetTextForLabel(myString);
                    }
                    else if (!(data == "OFF") || !(data == "ON"))
                    {
                        int x = 0;
                        if (Int32.TryParse(data, out x))
                        { 
                        x = (x / 5);
                        //String value3 = (String)value;
                        String myString = x.ToString();
                        myForm.SetTextForLabel(myString);
                            }
                        //rtfSerialOutput.AppendText(" xX" + data + "Xx ");
                    }
                    else{
                        // Do nothing; preventing messy label updating
                    }
                    // End test



                    rtfSerialOutput.ScrollToCaret();

                    //srlArduino.Write(textBox1.Text);
                    // "hello" is DB output
                    //rtfSerialOutput.AppendText(" Database output: " + hello + " ");
                    
                    // Database variable (hello) sent to arduino serial. ERROR: This data is always repeated.
                    // For some reason can only be performed max. 1x per second.
                    // Send this to the arduino, not the program. Let the arduino send it back as new response. 
                    srlArduino.Write(hello); // Send DB data to Arduino

                    /*string s1 = hello;
                    string s2 = "1";
                    bool b;
                    b = s1.Contains(s2);
                    if (b == true)
                        System.Media.SystemSounds.Asterisk.Play();
                    else
                    {
                        System.Media.SystemSounds.Exclamation.Play();
                    }*/

                    //textBox1.Text = hello;

                    
                    

                }
               
            }));

                
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            // Find COM ports
            findSerialPorts();

            // Connects to Database
            Thread thread = new Thread(new ThreadStart(ConnectToDB));
            thread.Start();

            // Loads User GUI settings
            loadGUISettings();

        }

        private void loadGUISettings()
        {
            this.BackColor = Properties.Settings.Default.MainformColor;
            this.ForeColor = Properties.Settings.Default.MainformTextColor;
            Color menuColor = ControlPaint.Dark(this.BackColor);
            Color menuTextColor = ControlPaint.LightLight(this.BackColor);
            menuStrip1.BackColor = statusStrip1.BackColor = menuColor;
            menuStrip1.ForeColor = statusStrip1.ForeColor = menuTextColor;
            button1.BackColor = btnRefreshSerial.BackColor = btnBeginCommunication.BackColor = btnClearOutput.BackColor = btnStopCommunication.BackColor = Properties.Settings.Default.MainformButtonBGColor;
            button1.ForeColor = btnRefreshSerial.ForeColor = btnBeginCommunication.ForeColor = btnClearOutput.ForeColor = btnStopCommunication.ForeColor = Properties.Settings.Default.MainformButtonTextColor;
        }

        private void findSerialPorts()
        {
            cmboBaudRate.SelectedItem = "9600";
            srlArduino.BaudRate = int.Parse(cmboBaudRate.SelectedItem.ToString());
            // Uodate Labels
            lblCurrentActivity.Text = "Searching available serial COM ports ..";

            //Get available Com Ports.
            comPorts = SerialPort.GetPortNames();

            foreach (string port in comPorts)
            {
                cmboPortList.Items.Add(port);
            }
            
            // Update Labels
            lblCurrentActivity.Text = "Serial COM ports added ...";
            if (comPorts.Length < 1 || comPorts == null)
            {
                lblSerialStatus.Text = "No Ports Available";
                lblSerialStatus.ForeColor = red;
            }
            else
            {
                lblSerialStatus.Text = "Ports Found";
                lblSerialStatus.ForeColor = green;
                cmboPortList.SelectedIndex = 0;
                srlArduino.PortName = cmboPortList.SelectedItem.ToString();
            }
        }
        
        public void ConnectToDB()
        {
            string cs = @"Server =75.185.65.213; Port =3306; Database =test; Uid =root; Pwd =7hat9gegessen;";
            connection = new MySqlConnection(cs);
            
            try
            {
                lblCurrentActivity.Text = "Connecting to DB ...";
                connection.Open();
                lblDBStatus.Text = "Connected";
                lblCurrentActivity.Text = "";
                
                this.Invoke((MethodInvoker)delegate //Prevents Crossthreading errors
                {
                    lblDBStatus.ForeColor = green;
                });
            }
            catch {
                lblCurrentActivity.Text = "DB Connection Failed";
                lblDBStatus.Text = "Connection Failed";

                this.Invoke((MethodInvoker)delegate //Prevents Crossthreading errors
                {
                    lblDBStatus.ForeColor = red; 
                });
               
            }
                
        }

        private void cmboPortList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Set Arduino Serial Port to Selected Port
            srlArduino.PortName = cmboPortList.SelectedItem.ToString();
        }

        private void cmboBaudRate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Set Arduino Serial Port Baud Rate.
            srlArduino.BaudRate = int.Parse(cmboBaudRate.SelectedItem.ToString());
        }

        private void btnBeginCommunication_Click(object sender, EventArgs e)
        {
            // Display Cluster
            hideCluster();// reset
            startCluster();
           /* 
            
           
            
            // Open the com port
            SerialPort port = new SerialPort(srlArduino.PortName, srlArduino.BaudRate);
            try
            {
                
                port.Open();

                // Read serial data
                while (true)
                {
                    String s = Console.ReadLine();
                    if (s.Equals("exit"))
                    {
                        break;
                    }
                    port.Write(s + '\n');
                }
                toolStripStatusLabel5.Text = "COM Connected.";
            }
            catch
            {
                toolStripStatusLabel5.Text = "COM Connection Failed.";
                toolStripStatusLabel5.ForeColor = red;
                btnBeginCommunication.Enabled = true;
            }
            */

            //Prevent errors
            btnBeginCommunication.Enabled = false;
            srlArduino.Close();

            //Prevent Changing Setings While Open;
            cmboBaudRate.Enabled = false;
            cmboPortList.Enabled = false;

            bool error = false;

            try
            {
                // Open the port
                srlArduino.Open();
                button1.Enabled = true;
                btnStopCommunication.Enabled = true;
            }
            catch (UnauthorizedAccessException) { error = true; }
            catch (IOException) { error = true; }
            catch (ArgumentException) { error = true; }

            if (error) { 
                MessageBox.Show(this, "Could not open the COM port.  Most likely it is already in use, has been removed, or is unavailable.", "COM Port Unavalible", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                btnBeginCommunication.Enabled = true;
                cmboBaudRate.Enabled = true;
                cmboPortList.Enabled = true;
                button1.Enabled = false;
            }
            else { rtfSerialOutput.AppendText("Port Opened\n"); }
        }

        private void btnStopCommunication_Click(object sender, EventArgs e)
        {
            //Close port
            btnBeginCommunication.Enabled = true;
            cmboBaudRate.Enabled = true;
            cmboPortList.Enabled = true;
            btnStopCommunication.Enabled = false;
            button1.Enabled = false;

            try
            {
                srlArduino.Close();
            }
            catch
            {
                MessageBox.Show("There was a problem closing the port.");
            }

            //re-enable changing;
            cmboBaudRate.Enabled = true;
            cmboPortList.Enabled = true;

            CheckPorts();
            rtfSerialOutput.AppendText("Port Closed\n");

        }

        private void CheckPorts()
        {
            //See if new ports added or removed.
            cmboPortList.Items.Clear();

            comPorts = SerialPort.GetPortNames();

            //Write Available Com Ports to Dropdown
            foreach (string port in comPorts)
            {
                cmboPortList.Items.Add(port);
            }

        }

        private void btnClearOutput_Click(object sender, EventArgs e)
        {
            rtfSerialOutput.Clear();
        }

        private void ColorMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmiColorMenu = sender as ToolStripMenuItem;
            if(tsmiColorMenu.Text == "Default")
            {
                this.BackColor = grpSerialComs.BackColor = grpSerialOutput.BackColor = SystemColors.Control;
                btnStopCommunication.BackColor = btnClearOutput.BackColor = btnBeginCommunication.BackColor = SystemColors.Control;
                this.ForeColor = grpSerialComs.ForeColor = grpSerialOutput.ForeColor = btnStopCommunication.ForeColor = btnClearOutput.ForeColor = btnBeginCommunication.ForeColor = SystemColors.ControlText;
            }
            else if(tsmiColorMenu.Text.Contains(" "))
            {
                 clrBackColor = Color.FromName(tsmiColorMenu.Text.Replace(" ",""));
                 this.BackColor = grpSerialComs.BackColor = grpSerialOutput.BackColor = clrBackColor;

                 if (clrBackColor.R < 125 && clrBackColor.G < 125 && clrBackColor.B < 125)
                 {
                     this.ForeColor = grpSerialComs.ForeColor = grpSerialOutput.ForeColor = Color.White;

                 }
                 else
                 {
                     this.ForeColor = grpSerialComs.ForeColor = grpSerialOutput.ForeColor = SystemColors.ControlText;
                 }
            }
            else
            {
                clrBackColor = Color.FromName(tsmiColorMenu.Text);
                this.BackColor = grpSerialComs.BackColor = grpSerialOutput.BackColor = clrBackColor;

                if (clrBackColor.R < 125 && clrBackColor.G < 125 && clrBackColor.B < 125)
                {
                    this.ForeColor = grpSerialComs.ForeColor = grpSerialOutput.ForeColor = Color.White;

                }
                else
                {
                    this.ForeColor = grpSerialComs.ForeColor = grpSerialOutput.ForeColor = SystemColors.ControlText;
                }
            }

           
            
           
        }

        private void customThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColor frmThemeChoice = new frmColor(this);
            DialogResult rsltThemeChoice = frmThemeChoice.ShowDialog();
            if(rsltThemeChoice == System.Windows.Forms.DialogResult.OK)
            {
                btnBeginCommunication.BackColor = btnClearOutput.BackColor = button1.BackColor = btnRefreshSerial.BackColor = btnStopCommunication.BackColor = frmThemeChoice.buttonBack;
                btnBeginCommunication.ForeColor = btnClearOutput.ForeColor = button1.ForeColor = btnRefreshSerial.ForeColor = btnStopCommunication.ForeColor = frmThemeChoice.buttonFront;
                this.BackColor = grpSerialComs.BackColor = grpSerialOutput.BackColor = groupBox1.BackColor = frmThemeChoice.formBack;
                this.ForeColor = this.grpSerialComs.ForeColor = this.grpSerialOutput.ForeColor = this.groupBox1.ForeColor = frmThemeChoice.formFront;

            }
        }

        private void connectionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmData frmDatabase = new frmData();
            frmDatabase.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAboutApp = new frmAbout();
            frmAboutApp.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close port
            srlArduino.Close();

            Application.Exit();
        }

        // Saves user GUI settings
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainformColor = this.BackColor;
            Properties.Settings.Default.MainformTextColor = this.ForeColor;
            Properties.Settings.Default.MainformButtonBGColor = this.button1.BackColor;
            Properties.Settings.Default.MainformButtonTextColor = this.button1.ForeColor;
            Properties.Settings.Default.Save();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            { srlArduino.Write(textBox1.Text); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.IO.Ports.SerialPort.GetPortNames();
            string[] ports = SerialPort.GetPortNames();


            /// USB shit testing
            List<String> devices = new List<String>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();
            //Reset cmboBox
            cmboPortList.Items.Clear();

            int i = 0;
            foreach (var device in collection)
            {
                //MessageBox.Show("One device found" + i);
                cmboPortList.Items.Add(device);
               i++;
            }

            collection.Dispose();
                
            //End USB shit

            //MessageBox.Show("The following serial ports were found:");

            // Display each port name to the console. 
            foreach(string port in ports)
            {
                //MessageBox.Show(port);
            }
            //Puts Computer To Sleep...
            //Application.SetSuspendState(PowerState.Suspend, true, true);
           // Console.ReadLine();
        }

        Cluster1 myForm;
        // Instrument Cluster Stuff
        private void button3_Click(object sender, EventArgs e)
        {
            startCluster();

        }

        private void startCluster()
        {
            // Load instrument cluster...
            myForm = new Cluster1();
            myForm.Show();
            this.Activate();
            btnDisplayCluster.Enabled = false;
            btnHideCluster.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideCluster();
        }

        private void hideCluster()
        {
            // Close instrument cluster...
            if (myForm != null)
            {
                myForm.Close();

            }
            btnDisplayCluster.Enabled = true;
            btnHideCluster.Enabled = false;
        }

        private void cmboPortList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
                int value2 = trackBar1.Value;
                String myString = value2.ToString();
                myForm.SetTextForLabel(myString);
            
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int value2 = trackBar2.Value;
            String myString = value2.ToString();
            myForm.SetTextForLabel2(myString);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int value2 = trackBar3.Value;
            String myString = value2.ToString();
            myForm.SetTextForLabel(myString);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            int value2 = trackBar4.Value;
            String myString = value2.ToString();
            myForm.SetTextForLabel(myString);
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            int value2 = trackBar4.Value;
            String myString = value2.ToString();
            myForm.SetTextForLabel(myString);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Load instrument cluster...
            TouchPanel1 myFormNext = new TouchPanel1();
            myFormNext.Show();
            this.Activate();
            btnDisplayCluster.Enabled = false;
            btnHideCluster.Enabled = true;
        }
           // MessageBox.Show();
        }
    }

