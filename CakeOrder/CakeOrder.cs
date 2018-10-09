using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeOrder
{
    public partial class frmCakeOrder : Form
    {
        public frmCakeOrder()
        {
            InitializeComponent();
        }

        private void lbCakes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sc = lbCakes.Text;
            lblSelectedCake.Text = "Selected Cake: " + sc;
        }

        private void chkMacaroons_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAdditionalPrice();
        }

        private void chkStrawberries_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAdditionalPrice();
        }

        private void chkNuts_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAdditionalPrice();
        }

        private void chkChocolateFlakes_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAdditionalPrice();
        }
        
        public void CalculateAdditionalPrice()
        {
            int additionalPrice = 0;

            if(chkMacaroons.Checked)
            {
                additionalPrice = additionalPrice + 7;
            }
            if(chkStrawberries.Checked)
            {
                additionalPrice = additionalPrice + 4;
            }
            if(chkNuts.Checked)
            {
                additionalPrice = additionalPrice + 5;
            }
            if(chkChocolateFlakes.Checked)
            {
                additionalPrice = additionalPrice + 3;
            }

            lblAdditionalPrice.Text = "Additional Price: $" + additionalPrice;
        }

        private void rbDelivery_CheckedChanged(object sender, EventArgs e)
        {
            lblDeliveryOption.Text = "Delivery Option: Delivery";
        }

        private void rbPickUp_CheckedChanged(object sender, EventArgs e)
        {
            lblDeliveryOption.Text = "Delivery Option: Pick Up";
        }

        private void lblDeliveryOption_Click(object sender, EventArgs e)
        {

        }
    }
}
