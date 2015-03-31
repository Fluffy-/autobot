namespace Arduino
{
    partial class frmColor
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
            this.rdoFormColor = new System.Windows.Forms.RadioButton();
            this.rdoTextColor = new System.Windows.Forms.RadioButton();
            this.rdoButtonBackColor = new System.Windows.Forms.RadioButton();
            this.rdoButtonTextColor = new System.Windows.Forms.RadioButton();
            this.grpTheme = new System.Windows.Forms.GroupBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.rdoUseSliders = new System.Windows.Forms.RadioButton();
            this.rdoUseColorDialog = new System.Windows.Forms.RadioButton();
            this.grpChoice = new System.Windows.Forms.GroupBox();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.trckRed = new System.Windows.Forms.TrackBar();
            this.trckBlue = new System.Windows.Forms.TrackBar();
            this.trckGreen = new System.Windows.Forms.TrackBar();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.grpSliders = new System.Windows.Forms.GroupBox();
            this.txtHexCode = new System.Windows.Forms.TextBox();
            this.lblHexCode = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.grpTheme.SuspendLayout();
            this.grpChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            this.grpSliders.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoFormColor
            // 
            this.rdoFormColor.AutoSize = true;
            this.rdoFormColor.Location = new System.Drawing.Point(6, 19);
            this.rdoFormColor.Name = "rdoFormColor";
            this.rdoFormColor.Size = new System.Drawing.Size(106, 17);
            this.rdoFormColor.TabIndex = 0;
            this.rdoFormColor.TabStop = true;
            this.rdoFormColor.Text = "Form Back Color ";
            this.rdoFormColor.UseVisualStyleBackColor = true;
            this.rdoFormColor.CheckedChanged += new System.EventHandler(this.rdoButtonTextColor_CheckedChanged);
            // 
            // rdoTextColor
            // 
            this.rdoTextColor.AutoSize = true;
            this.rdoTextColor.Location = new System.Drawing.Point(6, 42);
            this.rdoTextColor.Name = "rdoTextColor";
            this.rdoTextColor.Size = new System.Drawing.Size(73, 17);
            this.rdoTextColor.TabIndex = 1;
            this.rdoTextColor.TabStop = true;
            this.rdoTextColor.Text = "Text Color";
            this.rdoTextColor.UseVisualStyleBackColor = true;
            this.rdoTextColor.CheckedChanged += new System.EventHandler(this.rdoButtonTextColor_CheckedChanged);
            // 
            // rdoButtonBackColor
            // 
            this.rdoButtonBackColor.AutoSize = true;
            this.rdoButtonBackColor.Location = new System.Drawing.Point(6, 65);
            this.rdoButtonBackColor.Name = "rdoButtonBackColor";
            this.rdoButtonBackColor.Size = new System.Drawing.Size(111, 17);
            this.rdoButtonBackColor.TabIndex = 2;
            this.rdoButtonBackColor.TabStop = true;
            this.rdoButtonBackColor.Text = "Button Back Color";
            this.rdoButtonBackColor.UseVisualStyleBackColor = true;
            this.rdoButtonBackColor.CheckedChanged += new System.EventHandler(this.rdoButtonTextColor_CheckedChanged);
            // 
            // rdoButtonTextColor
            // 
            this.rdoButtonTextColor.AutoSize = true;
            this.rdoButtonTextColor.Location = new System.Drawing.Point(6, 88);
            this.rdoButtonTextColor.Name = "rdoButtonTextColor";
            this.rdoButtonTextColor.Size = new System.Drawing.Size(107, 17);
            this.rdoButtonTextColor.TabIndex = 3;
            this.rdoButtonTextColor.TabStop = true;
            this.rdoButtonTextColor.Text = "Button Text Color";
            this.rdoButtonTextColor.UseVisualStyleBackColor = true;
            this.rdoButtonTextColor.CheckedChanged += new System.EventHandler(this.rdoButtonTextColor_CheckedChanged);
            // 
            // grpTheme
            // 
            this.grpTheme.Controls.Add(this.rdoFormColor);
            this.grpTheme.Controls.Add(this.rdoButtonTextColor);
            this.grpTheme.Controls.Add(this.rdoTextColor);
            this.grpTheme.Controls.Add(this.rdoButtonBackColor);
            this.grpTheme.Location = new System.Drawing.Point(12, 12);
            this.grpTheme.Name = "grpTheme";
            this.grpTheme.Size = new System.Drawing.Size(233, 121);
            this.grpTheme.TabIndex = 4;
            this.grpTheme.TabStop = false;
            this.grpTheme.Text = "Theme Item";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(13, 140);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(112, 23);
            this.btnPreview.TabIndex = 5;
            this.btnPreview.Text = "Button Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // rdoUseSliders
            // 
            this.rdoUseSliders.AutoSize = true;
            this.rdoUseSliders.Location = new System.Drawing.Point(6, 19);
            this.rdoUseSliders.Name = "rdoUseSliders";
            this.rdoUseSliders.Size = new System.Drawing.Size(78, 17);
            this.rdoUseSliders.TabIndex = 6;
            this.rdoUseSliders.TabStop = true;
            this.rdoUseSliders.Text = "Use Sliders";
            this.rdoUseSliders.UseVisualStyleBackColor = true;
            this.rdoUseSliders.CheckedChanged += new System.EventHandler(this.rdoUseColorDialog_CheckedChanged);
            // 
            // rdoUseColorDialog
            // 
            this.rdoUseColorDialog.AutoSize = true;
            this.rdoUseColorDialog.Checked = true;
            this.rdoUseColorDialog.Location = new System.Drawing.Point(6, 42);
            this.rdoUseColorDialog.Name = "rdoUseColorDialog";
            this.rdoUseColorDialog.Size = new System.Drawing.Size(107, 17);
            this.rdoUseColorDialog.TabIndex = 7;
            this.rdoUseColorDialog.TabStop = true;
            this.rdoUseColorDialog.Text = "Use Color Dialog ";
            this.rdoUseColorDialog.UseVisualStyleBackColor = true;
            this.rdoUseColorDialog.CheckedChanged += new System.EventHandler(this.rdoUseColorDialog_CheckedChanged);
            // 
            // grpChoice
            // 
            this.grpChoice.Controls.Add(this.btnChooseColor);
            this.grpChoice.Controls.Add(this.rdoUseSliders);
            this.grpChoice.Controls.Add(this.rdoUseColorDialog);
            this.grpChoice.Location = new System.Drawing.Point(12, 169);
            this.grpChoice.Name = "grpChoice";
            this.grpChoice.Size = new System.Drawing.Size(200, 111);
            this.grpChoice.TabIndex = 8;
            this.grpChoice.TabStop = false;
            this.grpChoice.Text = "Method";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(7, 71);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(91, 23);
            this.btnChooseColor.TabIndex = 8;
            this.btnChooseColor.Text = "Choose Color";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // trckRed
            // 
            this.trckRed.Location = new System.Drawing.Point(28, 29);
            this.trckRed.Maximum = 255;
            this.trckRed.Name = "trckRed";
            this.trckRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckRed.Size = new System.Drawing.Size(45, 375);
            this.trckRed.SmallChange = 2;
            this.trckRed.TabIndex = 9;
            this.trckRed.TickFrequency = 10;
            this.trckRed.Scroll += new System.EventHandler(this.trckRed_Scroll);
            // 
            // trckBlue
            // 
            this.trckBlue.Location = new System.Drawing.Point(253, 29);
            this.trckBlue.Maximum = 255;
            this.trckBlue.Name = "trckBlue";
            this.trckBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckBlue.Size = new System.Drawing.Size(45, 375);
            this.trckBlue.SmallChange = 2;
            this.trckBlue.TabIndex = 10;
            this.trckBlue.TickFrequency = 10;
            this.trckBlue.Scroll += new System.EventHandler(this.trckBlue_Scroll);
            // 
            // trckGreen
            // 
            this.trckGreen.Location = new System.Drawing.Point(144, 29);
            this.trckGreen.Maximum = 255;
            this.trckGreen.Name = "trckGreen";
            this.trckGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trckGreen.Size = new System.Drawing.Size(45, 375);
            this.trckGreen.SmallChange = 2;
            this.trckGreen.TabIndex = 11;
            this.trckGreen.TickFrequency = 10;
            this.trckGreen.Scroll += new System.EventHandler(this.trckGreen_Scroll);
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(144, 410);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(45, 20);
            this.nudGreen.TabIndex = 12;
            this.nudGreen.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(253, 410);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(45, 20);
            this.nudBlue.TabIndex = 13;
            this.nudBlue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(28, 410);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(45, 20);
            this.nudRed.TabIndex = 14;
            this.nudRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(250, 13);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 15;
            this.lblBlue.Text = "Blue";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(141, 13);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 16;
            this.lblGreen.Text = "Green";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(25, 13);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 17;
            this.lblRed.Text = "Red";
            // 
            // grpSliders
            // 
            this.grpSliders.Controls.Add(this.lblRed);
            this.grpSliders.Controls.Add(this.trckRed);
            this.grpSliders.Controls.Add(this.lblGreen);
            this.grpSliders.Controls.Add(this.trckBlue);
            this.grpSliders.Controls.Add(this.lblBlue);
            this.grpSliders.Controls.Add(this.trckGreen);
            this.grpSliders.Controls.Add(this.nudRed);
            this.grpSliders.Controls.Add(this.nudGreen);
            this.grpSliders.Controls.Add(this.nudBlue);
            this.grpSliders.Location = new System.Drawing.Point(353, 12);
            this.grpSliders.Name = "grpSliders";
            this.grpSliders.Size = new System.Drawing.Size(313, 439);
            this.grpSliders.TabIndex = 18;
            this.grpSliders.TabStop = false;
            // 
            // txtHexCode
            // 
            this.txtHexCode.Location = new System.Drawing.Point(18, 287);
            this.txtHexCode.Name = "txtHexCode";
            this.txtHexCode.Size = new System.Drawing.Size(100, 20);
            this.txtHexCode.TabIndex = 19;
            // 
            // lblHexCode
            // 
            this.lblHexCode.AutoSize = true;
            this.lblHexCode.Location = new System.Drawing.Point(124, 290);
            this.lblHexCode.Name = "lblHexCode";
            this.lblHexCode.Size = new System.Drawing.Size(142, 13);
            this.lblHexCode.TabIndex = 20;
            this.lblHexCode.Text = "Color Hex Code and preview";
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(185, 428);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 23;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(266, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 463);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblHexCode);
            this.Controls.Add(this.txtHexCode);
            this.Controls.Add(this.grpSliders);
            this.Controls.Add(this.grpChoice);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.grpTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmColor";
            this.Text = "frmColor";
            this.Load += new System.EventHandler(this.frmColor_Load);
            this.grpTheme.ResumeLayout(false);
            this.grpTheme.PerformLayout();
            this.grpChoice.ResumeLayout(false);
            this.grpChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            this.grpSliders.ResumeLayout(false);
            this.grpSliders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoFormColor;
        private System.Windows.Forms.RadioButton rdoTextColor;
        private System.Windows.Forms.RadioButton rdoButtonBackColor;
        private System.Windows.Forms.RadioButton rdoButtonTextColor;
        private System.Windows.Forms.GroupBox grpTheme;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.RadioButton rdoUseSliders;
        private System.Windows.Forms.RadioButton rdoUseColorDialog;
        private System.Windows.Forms.GroupBox grpChoice;
        private System.Windows.Forms.TrackBar trckRed;
        private System.Windows.Forms.TrackBar trckBlue;
        private System.Windows.Forms.TrackBar trckGreen;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.GroupBox grpSliders;
        private System.Windows.Forms.TextBox txtHexCode;
        private System.Windows.Forms.Label lblHexCode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button btnAccept;
    }
}