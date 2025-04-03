using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class frm_BMI : Form
    {
        public frm_BMI()
        {
            InitializeComponent();
        }

        private void btnBMICalculater_Click(object sender, EventArgs e)
        {
            double BMI, Weight, Height;

            Weight = 0;
            Height = 0;
            BMI = 0;

            Weight = Convert.ToDouble(txtWeight.Text);
            Height = Convert.ToDouble(txtHeight.Text);

            BMI = Weight / (Height * Height);

            lblDisplay.Text = "Your BMI is : "+ BMI; 


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
