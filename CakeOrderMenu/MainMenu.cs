using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeOrderMenu
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        //cake options
        private void vanillaCakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDisplayOptions.Text = "Customer Choice: Vanilla Cake, Price: $25";
        }
        private void chocolateCakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDisplayOptions.Text = "Customer Choice: Chocolate Cake, Price: $25";
        }
        private void blackForrestCakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDisplayOptions.Text = "Customer Choice: Black Forest Cake, Price: $30";
        }
        private void whiteForrestCakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDisplayOptions.Text = "Customer Choice: White Forest Cake. Price: $25";
        }
        private void oreoCheesecakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDisplayOptions.Text = "Customer Choice: Oreo Cheese Cake, Price $25";
        }
        private void strawberryCheeseCakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDisplayOptions.Text = "Customer Choice: Strawberry Cheesecake, Price: $35";
        }

        //addtional toppings options
        private void macaroonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblToppings.Text = "Toppings: Macaroons, Additional Price: $7";
        }
        private void strawberriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblToppings.Text = "Toppings: Fruits, Additional Price: $4";
        }
        private void nutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblToppings.Text = "Toppings: Nuts, Additional Price: $5";
        }
        private void chocolateFlakesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblToppings.Text = "Toppings: Chocolate Flakes, Additonal Price $3";
        }

        //delivery options
        private void pickUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDeliveryOptions.Text = "Delivery Option: Pick Up";
        }
        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDeliveryOptions.Text = "Delivery Option: Delivery";
        }

        //about menu option
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAbout();
            frm1.ShowDialog(this);
        }

        //right click context menu. change font and fore/background colour
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog newFont = new FontDialog();
            if (newFont.ShowDialog() == DialogResult.OK)
            {
                lblDisplayOptions.Font = newFont.Font;
            }
        }
        private void foreColuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog newForeColor = new ColorDialog();
            if ( newForeColor.ShowDialog() == DialogResult.OK)
            {
                lblDisplayOptions.ForeColor = newForeColor.Color;
            }
        }
        private void backColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog newBackColor = new ColorDialog();
            if (newBackColor.ShowDialog() == DialogResult.OK)
            {
                lblDisplayOptions.BackColor = newBackColor.Color;
            }
        }
    }
}
