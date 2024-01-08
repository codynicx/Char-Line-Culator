using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageCalculator
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        double VtxtLength, VtxtWidth, VtxtRight, VtxtLeft, VtxtTop, VtxtBottom, VtxtPointSize;
        decimal d;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        //Calculate Method

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                VtxtLength    = Double.Parse(txtLength.Text);
                VtxtWidth     = Double.Parse(txtWidth.Text);
                VtxtRight     = Double.Parse(txtRight.Text);
                VtxtLeft      = Double.Parse(txtLeft.Text);
                VtxtTop       = Double.Parse(txtTop.Text);
                VtxtBottom    = Double.Parse(txtBottom.Text);
                VtxtPointSize = Double.Parse(txtPointSize.Text);

                if (comboBox_Spacing.SelectedIndex == 1)
                {
                    VtxtPointSize = (VtxtPointSize * 2);
                }
                VtxtLength   = VtxtLength - (VtxtTop + VtxtBottom);
                VtxtWidth    = VtxtWidth - (VtxtRight + VtxtLeft);
                double chars = (int)(VtxtWidth * (72)) / (VtxtPointSize);
                int numChar  = (int)(chars); 
                double lines = (VtxtLength * (72)) / (VtxtPointSize) - 1;
                int numLines = (int)(lines);

                MessageBox.Show("The number of characters: " + numChar + "\nThe number of lines: " + numLines);

            } catch (FormatException ex)

            {
                MessageBox.Show("Something went wrong\nThere's an input missing!");
            }
        }

        //Clear Method
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtRight.Text       = null;
            txtLeft.Text        = null;
            txtTop.Text         = null;
            txtBottom.Text      = null;
            txtPointSize.Text   = null;
            txtWidth.ForeColor  = Color.Silver;
            txtLength.ForeColor = Color.Silver;
            txtLength.Text      = "Write length in inches";
            txtWidth.Text       = "Write width in inches";

            comboBox_Spacing.Items.Add(""); 
            comboBox_Spacing.SelectedIndex = 2;
        }

        private void txtLength_Click(object sender, EventArgs e)
        {
            txtLength.Text = null;
        }
        private void txtWidth_Click(object sender, EventArgs e)
        {
            txtWidth.Text = null;
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }
        //Leave method
        private void txtLength_Leave(object sender, EventArgs e)
        {
            if (txtLength.Text == "")
            {
                txtLength.Text = "Write length in inches";
                txtLength.ForeColor = Color.Silver;
            }

            if (!(decimal.TryParse(txtLength.Text, out d)) && !(txtLength.Text == "Write length in inches"))
            {
                MessageBox.Show("Your length size is not a valid number!\nPlease try again. ");
                txtLength.Text = "Write length in inches";
                txtLength.ForeColor = Color.Silver;
            }
        }
        private void txtWidth_Leave(object sender, EventArgs e)
        {
            if (txtWidth.Text == "")
            {
                txtWidth.Text = "Write width in inches";
                txtWidth.ForeColor = Color.Silver;
            }

            if (!(decimal.TryParse(txtWidth.Text, out d)) && !(txtWidth.Text == "Write width in inches"))
            {
                MessageBox.Show("Your width size is not a valid number!\nPlease try again. ");
                txtWidth.Text = "Write width in inches";
                txtWidth.ForeColor = Color.Silver;
            }
        }
        private void txtLeft_Leave(object sender, EventArgs e)
        {
            if (!(decimal.TryParse(txtLeft.Text, out d)) && !(txtLeft.Text == ""))
            {
                MessageBox.Show("Your Left Margin is not a valid number!\nPlease try again. ");
            }
        }
        private void txtRight_Leave(object sender, EventArgs e)
        {
            if (!(decimal.TryParse(txtRight.Text, out d)) && !(txtRight.Text == ""))
            {
                MessageBox.Show("Your Right Margin is not a valid number!\nPlease try again. ");
            }
        }
        private void txtTop_Leave(object sender, EventArgs e)
        {
            if (!(decimal.TryParse(txtTop.Text, out d)) && !(txtTop.Text == ""))
            {
                MessageBox.Show("Your Top Margin is not a valid number!\nPlease try again. ");
            }
        }
        private void txtBottom_Leave(object sender, EventArgs e)
        {
            if (!(decimal.TryParse(txtBottom.Text, out d)) && !(txtBottom.Text == ""))
            {
                MessageBox.Show("Your Bottom Margin is not a valid number!\nPlease try again. ");
            }
        }
        private void txtPointSize_Leave(object sender, EventArgs e)
        {
            if (!(decimal.TryParse(txtPointSize.Text, out d)) && !(txtPointSize.Text == ""))
            {
                MessageBox.Show("Your Point Size is not a valid number!\nPlease try again. ");
            }
        }
    
        private void comboBox_Spacing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Spacing_Click(object sender, EventArgs e)
        {
            comboBox_Spacing.Items.Remove("");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPointSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLength_Enter(object sender, EventArgs e)
        {
            if(txtLength.Text == "Write length in inches")
            {
                txtLength.Text = ""; // making the previous input to be null

                txtLength.ForeColor = Color.Black; // changing the font color when the user started to input a value
            }
        }

        private void txtWidth_Enter(object sender, EventArgs e)
        {
            if (txtWidth.Text == "Write width in inches")
            {
                txtWidth.Text = "";

                txtWidth.ForeColor = Color.Black;
            }
        }
    }
}
