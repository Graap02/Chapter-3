using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class MadLibs : Form
    {
        public MadLibs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text);

            txtResult.Text = "The " + txtColor.Text + " Dragon is the " + txtWordEst.Text +
                " Dragon of all. It has " + num + " " + txtBDPP.Text + ", and a " + txtAnimal.Text + " shaped like a " + txtNoun.Text +
                ", although it will feast on nearly anything.";
        }
    }
}
