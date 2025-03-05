using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        int mDiscountType = 3;
        bool mDiscount = false;

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            if (chkDiscount.Checked)
                { mDiscount = true; mDiscountType = 1; }
            else if (chkChild.Checked)
                { mDiscount = true; mDiscountType = 2; }
            else
                { mDiscount = false; }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }
            if (radBack.Checked)  //added by Kingson
                { mSection = 4; }  //added by Kingson

            mTicketPrice = new TicketPrice(mSection, mDiscountType, mQuantity, mDiscount);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

        private void chkChild_CheckedChanged(object sender, EventArgs e)
        {
            chkDiscount.Checked = false;
        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            chkChild.Checked = false;
        }
    }
}
