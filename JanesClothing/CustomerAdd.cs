using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JanesClothing
{
    public partial class frmCustomerAdd : Form
    {
        public frmCustomerAdd()
        {
            InitializeComponent();
        }

        private void frmCustomerAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //when closing, shows main form and hides add customer form
            frmMainForm mainForm = new frmMainForm();
            mainForm.Show();
            Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //code to add customer details
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //closes form
            Close();
        }
    }
}
