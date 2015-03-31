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
    public partial class TouchPanel1 : Form
    {
        public TouchPanel1()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 0;
            this.Top = 420;
// add in: get height of instrument cluster, then position at bottom of cluster
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
