using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pricePerDay = 20;
            double pricePerMile = 0.25;
            double milePrice;
            double dailyPrice;
            double total;

            milePrice = Convert.ToInt32(txtMiles.Text) * pricePerMile;
            dailyPrice = Convert.ToInt32(txtDays.Text) * pricePerDay;
            total = milePrice + dailyPrice;

            lblResult.Text = "Your total is $" + total;
        }
    }
}
