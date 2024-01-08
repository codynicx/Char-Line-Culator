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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlLoad.Width += 2;

            if (pnlLoad.Width >= 500)
            {
                timer1.Stop();
                this.Hide();
                Form1 mode = new Form1();
                mode.Closed += (s, args) => this.Close();
                mode.Show();
            }
        }

        private void pnlLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
