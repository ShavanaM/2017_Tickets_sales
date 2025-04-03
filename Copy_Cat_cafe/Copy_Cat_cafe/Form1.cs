using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copy_Cat_cafe
{
    public partial class frm_Copy_Cat_Cafe : Form
    {
        public frm_Copy_Cat_Cafe()
        {
            InitializeComponent();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            int iCount, inoCopies, iPrice;
            double dCost,dSuperiorCost,dExtra;
 
            iCount = 0;
            inoCopies = 0;
            dCost = 0;
            iPrice = 0;
            dSuperiorCost = 0;
            dExtra = 0;

            inoCopies = Convert.ToInt16(txtNoCopies.Text);

            iCount =+ inoCopies;

            if (iCount < 501)
            { iPrice = 20;
                dSuperiorCost = 20 * 0.3;
            }

            if ((iCount > 500)&&(iCount<1001))
            { iPrice = 15;
                dSuperiorCost = 15 * 0.3;
            }

            if (iCount > 1000)
            { iPrice = 10;
                dSuperiorCost = 10 * 0.3;
            }

            if (radSuperior.Checked == true)
            { dExtra = inoCopies * dSuperiorCost;
                dCost = (inoCopies * iPrice) + dExtra;
            }

            if(radStandard.Checked == true)
            { dCost = inoCopies * iPrice; }


            lblDisplay.Text = "The Cost is: "+dCost;
            








        }
    }
}
