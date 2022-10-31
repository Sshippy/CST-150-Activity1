using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFirst_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSecond_Click(object sender, EventArgs e)
        {

        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(txtFirstNumber.Text);
            num2 = Convert.ToInt32(txtSecondNumber.Text);
            sum = num1 + num2;
            lblResult.Text = sum.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblResultText_Click(object sender, EventArgs e)
        {

        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPerimeter_Click(object sender, EventArgs e)
        {

        }

        private void lblPerimeterText_Click(object sender, EventArgs e)
        {

        }

        private void lblLength_Click(object sender, EventArgs e)
        {

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void lblAreaText_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(txtWidth.Text);
            int length = Convert.ToInt32(txtLength.Text);
            int area = width * length;
            int perimeter = (width + length) * 2;
            lblPerimeter.Text = "Perimeter : " + perimeter;
            lblArea.Text = "Area : " + area;
        }
    }
}
