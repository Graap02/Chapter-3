using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractive
{
    public partial class lblResult : Form
    {
        public lblResult()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eggsTotal;
            int dozenEggs = 12;
            int numDozen;
            int numEggsRemaining;

            eggsTotal = Convert.ToInt32(eggsOne.Text) + Convert.ToInt32(eggsTwo.Text) + Convert.ToInt32(eggsThree.Text) +
                Convert.ToInt32(eggsFour.Text) + Convert.ToInt32(eggsFive.Text);

            numDozen = eggsTotal / dozenEggs;
            numEggsRemaining = eggsTotal % dozenEggs;

            eggsResult.Text = eggsTotal + " eggs is " + numDozen + " with " + numEggsRemaining + " left over.";
        }
    }
}
