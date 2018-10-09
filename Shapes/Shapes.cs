using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class frmShapes : Form
    {
        public frmShapes()
        {
            InitializeComponent();
        }

        private void btnCalculateArea_Click(object sender, EventArgs e)
        {
            string selectedShape = cbSelectShape.Text;
            int area, length, width;

            if (selectedShape == "Rectangle")
            {
                length = Convert.ToInt32(txtEnterLength.Text);
                width = Convert.ToInt32(txtEnterWidth.Text);
                area = length * width;
                lblResult.Text = "Result: Area of the rectangle is " + area + "cm²";
            }
            else
            {
                length = Convert.ToInt32(txtEnterLength.Text);
                area = length * length;
                lblResult.Text = "Result: Area of the square is " + area + "cm²";
            }
        }
    }
}
