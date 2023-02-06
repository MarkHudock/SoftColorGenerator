using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        Color SourceColor;
        ColorUtility Utility;

        public Form1()
        {
            InitializeComponent();
            if (Utility == null)
            {
                Utility = new ColorUtility();
            }
            UpdateGenerated();
            this.ActiveControl = this.textBoxColor;
        }

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            if (textBoxColor.Text.Length > 0)
            {
                ValidateSourceHex();
                if (textBoxColor.Text.Length != 6)
                {
                    textBoxColor.ForeColor = Color.Red;
                }
                if (textBoxColor.Text.Length == 6)
                {
                    try
                    {
                        // Update Source Color text boxes.
                        UpdateSource();

                        // Update Generated Color text boxes.
                        UpdateGenerated();
                    }
                    catch (Exception)
                    {
                        textBoxColor.ForeColor = Color.Red;

                        textBoxGeneratedHex.Text = "ERROR";
                        textBoxGeneratedHex.ForeColor = Color.Red;
                        return;
                    }
                }
            }
        }

        private void ValidateSourceHex()
        {
            foreach(char c in textBoxColor.Text)
            {
                if (!ColorUtility.HEX_CHARACTERS.Contains(c))
                {
                    textBoxColor.Text = textBoxColor.Text.Remove(textBoxColor.Text.IndexOf(c), 1);
                }
            }
        }

        private void UpdateSource()
        {
            try
            {
                SourceColor = Utility.FromHex(textBoxColor.Text);

                // Update Source Color text boxes.

                textBoxColor.ForeColor = Color.Black;
                textBoxColorFill.BackColor = SourceColor;
                textBoxRed.Text = SourceColor.R.ToString();
                textBoxGreen.Text = SourceColor.G.ToString();
                textBoxBlue.Text = SourceColor.B.ToString();
            }
            catch (Exception)
            {
                textBoxColor.ForeColor = Color.Red;

                textBoxGeneratedHex.Text = "ERROR";
                textBoxGeneratedHex.ForeColor = Color.Red;
            }
        }

        private void UpdateGenerated()
        {
            try
            {
                Color GeneratedColor = Utility.GetColorForTransparency(SourceColor, radioButtonLight.Checked ? Color.White : Color.Black, trackBarSoftness.Value * 10);

                // Update Generated Color text boxes.
                textBoxGeneratedHex.Text = Utility.ToHex(GeneratedColor);
                textBoxGeneratedRed.Text = GeneratedColor.R.ToString();
                textBoxGeneratedGreen.Text = GeneratedColor.G.ToString();
                textBoxGeneratedBlue.Text = GeneratedColor.B.ToString();
                textBoxGeneratedFill.BackColor = GeneratedColor;

                labelExampleText.ForeColor = GeneratedColor;
            }
            catch (Exception)
            {
                textBoxGeneratedHex.Text = "ERROR";
                textBoxGeneratedHex.ForeColor = Color.Red;
            }
        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonLight.Checked)
            {
                UpdateGenerated();
            }
        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButtonDark.Checked)
            {
                UpdateGenerated();
            }
        }

        private void trackBarSoftness_Scroll(object sender, EventArgs e)
        {
            labelSoftnessPercent.Text = string.Format("{0}%", (trackBarSoftness.Value * 10).ToString());
            UpdateGenerated();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (trackBarSoftness.Value > trackBarSoftness.Minimum)
            {
                trackBarSoftness.Value--;
                labelSoftnessPercent.Text = string.Format("{0}%", (trackBarSoftness.Value * 10).ToString());
                UpdateGenerated();
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (trackBarSoftness.Value < trackBarSoftness.Maximum)
            {
                trackBarSoftness.Value++;
                labelSoftnessPercent.Text = string.Format("{0}%", (trackBarSoftness.Value * 10).ToString());
                UpdateGenerated();
            }
        }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRed.Text.Length > 0)
            {
                // Validate as a number.
                foreach (char c in textBoxRed.Text)
                {
                    if ((int)c < 48 || (int)c > 57) // 48 = 0, 57 = 9.
                    {
                        textBoxRed.Text = textBoxRed.Text.Remove(textBoxRed.Text.IndexOf(c), 1);
                    }
                }

                // Make sure the number is between 0 and 255.
                int output;
                if (int.TryParse(textBoxRed.Text, out output))
                {
                    if (output < 0 || output > 255)
                    {
                        textBoxRed.Text = "255";
                    }
                }
            }
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGreen.Text.Length > 0)
            {
                foreach (char c in textBoxGreen.Text)
                {
                    if ((int)c < 48 || (int)c > 57) // 48 = 0, 57 = 9.
                    {
                        textBoxGreen.Text = textBoxGreen.Text.Remove(textBoxGreen.Text.IndexOf(c), 1);
                    }
                }
                int output;
                if (int.TryParse(textBoxGreen.Text, out output))
                {
                    if (output < 0 || output > 255)
                    {
                        textBoxGreen.Text = "255";
                    }
                }
            }
        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBlue.Text.Length > 0)
            {
                foreach (char c in textBoxBlue.Text)
                {
                    if ((int)c < 48 || (int)c > 57) // 48 = 0, 57 = 9.
                    {
                        textBoxBlue.Text = textBoxBlue.Text.Remove(textBoxBlue.Text.IndexOf(c), 1);
                    }
                }
                int output;
                if (int.TryParse(textBoxBlue.Text, out output))
                {
                    if (output < 0 || output > 255)
                    {
                        textBoxBlue.Text = "255";
                    }
                }
            }
        }

    }
}
