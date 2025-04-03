using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_Tickets_sales
{
    public partial class frm_2017_Tickets_sales : Form
    {
        public frm_2017_Tickets_sales()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int onoTickets, inoTickets;
            decimal oPrice, iPrice, oTotal, iTotal;

            onoTickets = 0;
            inoTickets = 0;
            oPrice = 0;
            iPrice = 0;
            oTotal = 0;
            iTotal = 0;



            onoTickets = Convert.ToInt32(txtoNoTickets.Text);
            oPrice = Convert.ToDecimal(txtoPrice.Text);
            inoTickets = Convert.ToInt32(txtiNoTickets.Text);
            iPrice = Convert.ToDecimal(txtiPrice.Text);

            oTotal = onoTickets * oPrice;
            iTotal = inoTickets * iPrice;

            if (oTotal > iTotal)
            { lblDisplay.Text = "The top performing show:         " + "Outdoor"; }

            else

            if (iTotal > oTotal)
            { lblDisplay.Text = "The top performing show:         " + "Indoor"; }

            else

            if (oTotal == iTotal)
            { lblDisplay.Text = "The top performing show:         " + "Both shows are equal"; }











        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
