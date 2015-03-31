namespace Arduino
{
    partial class frmData
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.arduPort = new System.IO.Ports.SerialPort(this.components);
            this.grpAppData = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblDataApp = new System.Windows.Forms.Label();
            this.grpCustomData = new System.Windows.Forms.GroupBox();
            this.btnCustomConnect = new System.Windows.Forms.Button();
            this.txt5Password = new System.Windows.Forms.TextBox();
            this.txt4Username = new System.Windows.Forms.TextBox();
            this.txt3Database = new System.Windows.Forms.TextBox();
            this.txt2PortNumber = new System.Windows.Forms.TextBox();
            this.txt1ServerAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.grpAppData.SuspendLayout();
            this.grpCustomData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAppData
            // 
            this.grpAppData.Controls.Add(this.btnConnect);
            this.grpAppData.Controls.Add(this.lblDataApp);
            this.grpAppData.Location = new System.Drawing.Point(12, 12);
            this.grpAppData.Name = "grpAppData";
            this.grpAppData.Size = new System.Drawing.Size(185, 85);
            this.grpAppData.TabIndex = 0;
            this.grpAppData.TabStop = false;
            this.grpAppData.Text = "Application Database";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 50);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblDataApp
            // 
            this.lblDataApp.AutoSize = true;
            this.lblDataApp.Location = new System.Drawing.Point(6, 33);
            this.lblDataApp.Name = "lblDataApp";
            this.lblDataApp.Size = new System.Drawing.Size(162, 13);
            this.lblDataApp.TabIndex = 0;
            this.lblDataApp.Text = "Connect to application Database";
            // 
            // grpCustomData
            // 
            this.grpCustomData.Controls.Add(this.btnCustomConnect);
            this.grpCustomData.Controls.Add(this.txt5Password);
            this.grpCustomData.Controls.Add(this.txt4Username);
            this.grpCustomData.Controls.Add(this.txt3Database);
            this.grpCustomData.Controls.Add(this.txt2PortNumber);
            this.grpCustomData.Controls.Add(this.txt1ServerAddress);
            this.grpCustomData.Controls.Add(this.label7);
            this.grpCustomData.Controls.Add(this.label6);
            this.grpCustomData.Controls.Add(this.label5);
            this.grpCustomData.Controls.Add(this.label4);
            this.grpCustomData.Controls.Add(this.label3);
            this.grpCustomData.Location = new System.Drawing.Point(12, 103);
            this.grpCustomData.Name = "grpCustomData";
            this.grpCustomData.Size = new System.Drawing.Size(264, 206);
            this.grpCustomData.TabIndex = 1;
            this.grpCustomData.TabStop = false;
            this.grpCustomData.Text = "CustomDatabase";
            // 
            // btnCustomConnect
            // 
            this.btnCustomConnect.Location = new System.Drawing.Point(183, 162);
            this.btnCustomConnect.Name = "btnCustomConnect";
            this.btnCustomConnect.Size = new System.Drawing.Size(75, 23);
            this.btnCustomConnect.TabIndex = 24;
            this.btnCustomConnect.Text = "Connect";
            this.btnCustomConnect.UseVisualStyleBackColor = true;
            this.btnCustomConnect.Click += new System.EventHandler(this.btnCustomConnect_Click);
            // 
            // txt5Password
            // 
            this.txt5Password.Location = new System.Drawing.Point(90, 136);
            this.txt5Password.Name = "txt5Password";
            this.txt5Password.Size = new System.Drawing.Size(100, 20);
            this.txt5Password.TabIndex = 23;
            // 
            // txt4Username
            // 
            this.txt4Username.Location = new System.Drawing.Point(90, 110);
            this.txt4Username.Name = "txt4Username";
            this.txt4Username.Size = new System.Drawing.Size(100, 20);
            this.txt4Username.TabIndex = 22;
            // 
            // txt3Database
            // 
            this.txt3Database.Location = new System.Drawing.Point(90, 84);
            this.txt3Database.Name = "txt3Database";
            this.txt3Database.Size = new System.Drawing.Size(100, 20);
            this.txt3Database.TabIndex = 21;
            // 
            // txt2PortNumber
            // 
            this.txt2PortNumber.Location = new System.Drawing.Point(90, 58);
            this.txt2PortNumber.Name = "txt2PortNumber";
            this.txt2PortNumber.Size = new System.Drawing.Size(100, 20);
            this.txt2PortNumber.TabIndex = 20;
            // 
            // txt1ServerAddress
            // 
            this.txt1ServerAddress.Location = new System.Drawing.Point(90, 32);
            this.txt1ServerAddress.Name = "txt1ServerAddress";
            this.txt1ServerAddress.Size = new System.Drawing.Size(100, 20);
            this.txt1ServerAddress.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Database:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Server Address:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(195, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(114, 315);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 351);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpCustomData);
            this.Controls.Add(this.grpAppData);
            this.Name = "frmData";
            this.Text = "frmData";
            this.Load += new System.EventHandler(this.frmData_Load);
            this.grpAppData.ResumeLayout(false);
            this.grpAppData.PerformLayout();
            this.grpCustomData.ResumeLayout(false);
            this.grpCustomData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort arduPort;
        private System.Windows.Forms.GroupBox grpAppData;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblDataApp;
        private System.Windows.Forms.GroupBox grpCustomData;
        private System.Windows.Forms.Button btnCustomConnect;
        private System.Windows.Forms.TextBox txt5Password;
        private System.Windows.Forms.TextBox txt4Username;
        private System.Windows.Forms.TextBox txt3Database;
        private System.Windows.Forms.TextBox txt2PortNumber;
        private System.Windows.Forms.TextBox txt1ServerAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
    }
}