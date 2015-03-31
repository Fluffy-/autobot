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
    public partial class frmColor : Form
    {
        private frmMain m_Mainform;
        private string themeChoice;

        public Color formBack;
        public Color formFront;
        public Color buttonBack;
        public Color buttonFront;


        Color clrVariablesFrmBack; 
        Color clrVariablesFrmText; 
        Color clrVariablesBtnBack; 
        Color clrVariablesBtnText;

        public frmColor(frmMain f)
        {
            m_Mainform = f;
            InitializeComponent();
        }

        private void rdoButtonTextColor_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoButtonBackColor.Checked)
            {
                themeChoice = "ButtonBack";
            }
            else if(rdoButtonTextColor.Checked)
            {
                themeChoice = "ButtonText";
            }
            else if(rdoFormColor.Checked)
            {
                themeChoice = "FormBack";
            }
            else if(rdoTextColor.Checked)
            {
                themeChoice = "FormText";
            }

        }

        private void rdoUseColorDialog_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoUseColorDialog.Checked)
            {
                while(this.Width > 364)
                {
                    this.Width = this.Width - 1;
                }
            }
            else if(rdoUseSliders.Checked)
            {
                while(this.Width < 694)
                {
                    this.Width = this.Width + 1;
                }
            }

            GetCurrentColor();
        }


        private void trckRed_Scroll(object sender, EventArgs e)
        {
            TrackBar redHandle = sender as TrackBar;
            Color myColor = Color.FromArgb(trckRed.Value, trckGreen.Value, trckBlue.Value);
            switch (themeChoice)
            {
                case "ButtonBack":
                    btnPreview.ForeColor = myColor;
                    ColorToHex(myColor);
                    break;
                case "ButtonText":
                    btnPreview.BackColor = myColor;
                    ColorToHex(myColor);
                    break;
                case "FormBack":
                    ColorToHexForm(myColor);
                    txtHexCode.BackColor = myColor;
                    break;
                case "FormText":
                    ColorToHex(myColor);
                    txtHexCode.ForeColor = myColor;
                    break;
            }
            nudRed.Value = redHandle.Value;
        }

        private void ColorToHex(Color clrChoice)
        {
            string clrHex = clrChoice.R.ToString("X2") + clrChoice.G.ToString("X2") + clrChoice.B.ToString("X2");
            this.Text = clrHex;
        }

        private void trckGreen_Scroll(object sender, EventArgs e)
        {
            TrackBar greenHandle = sender as TrackBar;
            Color myColor = Color.FromArgb(trckRed.Value, trckGreen.Value, trckBlue.Value);
            switch (themeChoice)
            {
                case "ButtonBack":
                    btnPreview.BackColor = myColor;
                    ColorToHex(myColor);
                    break;
                case "ButtonText":
                    btnPreview.ForeColor = myColor;
                    ColorToHex(myColor);
                    break;
                case "FormBack":
                    ColorToHexForm(myColor);
                    txtHexCode.BackColor = myColor;
                    break;
                case "FormText":
                    txtHexCode.ForeColor = myColor;
                    ColorToHex(myColor);
                    break;
            }
            nudGreen.Value = greenHandle.Value;
        }

        private void trckBlue_Scroll(object sender, EventArgs e)
        {
            TrackBar blueHandle = sender as TrackBar;
            Color myColor = Color.FromArgb(trckRed.Value, trckGreen.Value, trckBlue.Value);
            switch (themeChoice)
            {
                case "ButtonBack":
                    ColorToHex(myColor);
                    btnPreview.BackColor = myColor;
                    break;
                case "ButtonText":
                    ColorToHex(myColor);
                    btnPreview.ForeColor = myColor;
                    break;
                case "FormBack":
                    txtHexCode.BackColor = myColor;
                    ColorToHexForm(myColor);
                    break;
                case "FormText" :
                    txtHexCode.ForeColor = myColor;
                    ColorToHex(myColor);
                    break;
            }
            nudBlue.Value = blueHandle.Value;
        }

        private void ColorToHexForm(Color clrChoice)
        {
            string clrHex = clrChoice.R.ToString("X2") + clrChoice.G.ToString("X2") + clrChoice.B.ToString("X2");
            txtHexCode.Text = clrHex;
            
        }


        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (rdoUseColorDialog.Checked)
            {
                DialogResult clrChosen = colorDialog1.ShowDialog();
                if(clrChosen == System.Windows.Forms.DialogResult.OK)
                {
                    switch (themeChoice)
                    {
                        case "ButtonBack":
                            buttonBack = colorDialog1.Color;
                            btnPreview.BackColor = colorDialog1.Color;
                            ColorToHexDialog(colorDialog1.Color);
                            break;
                        case "ButtonText":
                            buttonFront = colorDialog1.Color;
                            btnPreview.ForeColor = colorDialog1.Color;
                            ColorToHexDialog(colorDialog1.Color);
                            break;
                        case "FormBack":
                            formBack = colorDialog1.Color;
                            txtHexCode.BackColor = colorDialog1.Color;
                            ColorToHexFormDialog(colorDialog1.Color);
                            break;
                        case "FormText":
                            formFront = colorDialog1.Color;
                            txtHexCode.ForeColor = colorDialog1.Color;
                            ColorToHexDialog(colorDialog1.Color);
                            break;
                    }
                }
            }
            else if (rdoUseSliders.Checked)
            {
                switch (themeChoice)
                {
                    case "ButtonBack":
                        buttonBack = Color.FromArgb(trckRed.Value, trckGreen.Value, trckBlue.Value);
                        break;
                    case "ButtonText":
                        buttonBack = Color.FromArgb(trckRed.Value, trckGreen.Value, trckBlue.Value);
                        break;
                    case "FormBack":
                        buttonBack = Color.FromArgb(trckRed.Value, trckGreen.Value, trckBlue.Value);
                        break;
                    case "FormText":
                        buttonBack = Color.FromArgb(trckRed.Value, trckGreen.Value, trckBlue.Value);
                        break;
                }
            }
        }

        private void ColorToHexDialog(Color clrChoice)
        {
            string clrHex = clrChoice.R.ToString("X2") + clrChoice.G.ToString("X2") + clrChoice.B.ToString("X2");
            this.Text = clrHex;

        }

        private void ColorToHexFormDialog(Color clrChoice)
        {
            string clrHex = clrChoice.R.ToString("X2") + clrChoice.G.ToString("X2") + clrChoice.B.ToString("X2");
            txtHexCode.Text = clrHex;
        }

        private void frmColor_Load(object sender, EventArgs e)
        {
            GetCurrentColor();
        }

        private void GetCurrentColor()
        {
             clrVariablesFrmBack = Color.FromArgb(m_Mainform.BackColor.A, m_Mainform.BackColor.R, m_Mainform.BackColor.G, m_Mainform.BackColor.B);
             clrVariablesFrmText = Color.FromArgb(m_Mainform.ForeColor.A, m_Mainform.ForeColor.R, m_Mainform.ForeColor.G, m_Mainform.ForeColor.B);
             clrVariablesBtnBack = Color.FromArgb(m_Mainform.btnClearOutput.BackColor.A, m_Mainform.btnClearOutput.BackColor.R, m_Mainform.btnClearOutput.BackColor.G, m_Mainform.btnClearOutput.BackColor.B);
             clrVariablesBtnText = Color.FromArgb(m_Mainform.btnClearOutput.ForeColor.A, m_Mainform.btnClearOutput.ForeColor.R, m_Mainform.btnClearOutput.ForeColor.G, m_Mainform.btnClearOutput.ForeColor.B);

             btnPreview.BackColor = clrVariablesBtnBack;
             btnPreview.ForeColor = clrVariablesBtnText;

             txtHexCode.ForeColor = clrVariablesFrmText;
             txtHexCode.BackColor = clrVariablesFrmBack;

             ColorToHex(clrVariablesBtnBack);

             trckRed.Value = clrVariablesFrmBack.R;
             trckGreen.Value = clrVariablesFrmBack.G;
             trckBlue.Value = clrVariablesFrmBack.B;

             MatchScrollerValues();

             formBack = clrVariablesFrmBack;
             formFront = clrVariablesFrmText;
             buttonBack = clrVariablesBtnBack;
             buttonFront = clrVariablesBtnText;
        }

        private void MatchScrollerValues()
        {
            nudRed.Value = (decimal)trckRed.Value;
            nudGreen.Value = (decimal)trckGreen.Value;
            nudBlue.Value = (decimal)trckBlue.Value;

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
           //frmMain.BackColor = buttonBack;
        }
    }
}
