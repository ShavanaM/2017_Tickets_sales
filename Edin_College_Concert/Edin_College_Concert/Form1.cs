using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edin_College_Concert
{
    public partial class frm_Edin_College_Concert : Form
    {
        public frm_Edin_College_Concert()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string sName, sDay;
            int noAdults, noChildren;
            decimal dTCostA,dTCostC, dSCost, dTotal,dTCost;

            noAdults = 0;
            noChildren = 0;
            dTCostA = 0;
            dTCostC = 0;
            dTCost = 0;
            dSCost = 0;
            dTotal = 0;
          

            sName = txtName.Text;
            noAdults = Convert.ToInt16(txtAdult.Text);
            noChildren = Convert.ToInt32(txtChild.Text);

            if (radF.Checked == true)
            {

                dTCostA = noAdults * 45;
                dTCostC = 45 / 2 * noChildren;

                dTCost = dTCostA + dTCostC;

                sDay = "Friday";

                if (chkSP1.Checked)
                { dSCost = 30; }

                if (chkSP2.Checked)
                { dSCost = 45; }

                dTotal = dTCost + dSCost;


                lblDisplay.Text = "Name: "+sName+"\n"+"Number of Adults: "+noAdults+"\n"+"Number of Children: "+noChildren+"\n"+"Show Day: "+sDay+"\n"+"Ticket Cost: "+dTCost+"\n"+"Snack Cost: "+dSCost+"\n"+"Total Due(Incl Snacks): "+dTotal;

            }


        }
    }
}
