using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double total;
            double avg;

            total = Convert.ToDouble(txtScore1.Text) + Convert.ToDouble(txtScore2.Text) + Convert.ToDouble(txtScore3.Text) +
                Convert.ToDouble(txtScore4.Text) + Convert.ToDouble(txtScore5.Text);

            avg = total / 5;

            lblResults.Text = "Average score is: " + avg;
        }
    }
}
