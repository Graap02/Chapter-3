using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            double Salary;
            double raise = 4.0;
            double results;


            Salary = Convert.ToDouble(txtSalary.Text);
            results = Salary * raise;
            
            lblResults.Text = "New salary is " + results + ", which is up by 4%.";
        }

    }
}
