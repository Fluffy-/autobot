namespace Arduino
{

    partial class Cluster1
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code
        public System.Windows.Forms.Label label1;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblRPM = new System.Windows.Forms.Label();
            this.lblNumRPM = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblNumFuel = new System.Windows.Forms.Label();
            this.lblOilPressure = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblNumOilPressure = new System.Windows.Forms.Label();
            this.lblNumTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(584, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 113);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(636, 221);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(77, 31);
            this.lblSpeed.TabIndex = 1;
            this.lblSpeed.Text = "MPH";
            // 
            // lblRPM
            // 
            this.lblRPM.AutoSize = true;
            this.lblRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPM.Location = new System.Drawing.Point(931, 221);
            this.lblRPM.Name = "lblRPM";
            this.lblRPM.Size = new System.Drawing.Size(77, 31);
            this.lblRPM.TabIndex = 2;
            this.lblRPM.Text = "RPM";
            // 
            // lblNumRPM
            // 
            this.lblNumRPM.AutoSize = true;
            this.lblNumRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRPM.Location = new System.Drawing.Point(924, 127);
            this.lblNumRPM.Name = "lblNumRPM";
            this.lblNumRPM.Size = new System.Drawing.Size(71, 76);
            this.lblNumRPM.TabIndex = 3;
            this.lblNumRPM.Text = "0";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.Location = new System.Drawing.Point(1181, 221);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(71, 31);
            this.lblFuel.TabIndex = 4;
            this.lblFuel.Text = "Fuel";
            // 
            // lblNumFuel
            // 
            this.lblNumFuel.AutoSize = true;
            this.lblNumFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFuel.Location = new System.Drawing.Point(1199, 158);
            this.lblNumFuel.Name = "lblNumFuel";
            this.lblNumFuel.Size = new System.Drawing.Size(37, 39);
            this.lblNumFuel.TabIndex = 5;
            this.lblNumFuel.Text = "0";
            // 
            // lblOilPressure
            // 
            this.lblOilPressure.AutoSize = true;
            this.lblOilPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOilPressure.Location = new System.Drawing.Point(266, 221);
            this.lblOilPressure.Name = "lblOilPressure";
            this.lblOilPressure.Size = new System.Drawing.Size(175, 31);
            this.lblOilPressure.TabIndex = 6;
            this.lblOilPressure.Text = "Oil Pressure";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(36, 221);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(96, 31);
            this.lblTemp.TabIndex = 7;
            this.lblTemp.Text = "Temp.";
            // 
            // lblNumOilPressure
            // 
            this.lblNumOilPressure.AutoSize = true;
            this.lblNumOilPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOilPressure.Location = new System.Drawing.Point(314, 120);
            this.lblNumOilPressure.Name = "lblNumOilPressure";
            this.lblNumOilPressure.Size = new System.Drawing.Size(71, 76);
            this.lblNumOilPressure.TabIndex = 8;
            this.lblNumOilPressure.Text = "0";
            // 
            // lblNumTemp
            // 
            this.lblNumTemp.AutoSize = true;
            this.lblNumTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTemp.Location = new System.Drawing.Point(59, 151);
            this.lblNumTemp.Name = "lblNumTemp";
            this.lblNumTemp.Size = new System.Drawing.Size(37, 39);
            this.lblNumTemp.TabIndex = 9;
            this.lblNumTemp.Text = "0";
            // 
            // Cluster1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1354, 412);
            this.Controls.Add(this.lblNumTemp);
            this.Controls.Add(this.lblNumOilPressure);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblOilPressure);
            this.Controls.Add(this.lblNumFuel);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lblNumRPM);
            this.Controls.Add(this.lblRPM);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Cluster1";
            this.Text = "Cluster1";
            this.Load += new System.EventHandler(this.Cluster1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblRPM;
        public System.Windows.Forms.Label lblNumRPM;
        private System.Windows.Forms.Label lblFuel;
        public System.Windows.Forms.Label lblNumFuel;
        private System.Windows.Forms.Label lblOilPressure;
        private System.Windows.Forms.Label lblTemp;
        public System.Windows.Forms.Label lblNumOilPressure;
        public System.Windows.Forms.Label lblNumTemp;

        

    }
}