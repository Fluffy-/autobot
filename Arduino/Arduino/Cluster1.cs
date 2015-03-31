using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino
{

    public partial class Cluster1 : Form
    {
        public Cluster1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 0;
this.Top = 0;


        }
        public void SetTextForLabel(string myText)
        {
            label1.Text = myText;
        }
        public void SetTextForLabel2(string myText)
        {
           lblNumRPM.Text = myText;
        }
        public void SetTextForLabel3(string myText)
        {
            label1.Text = myText;
        }

        private void Cluster1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
