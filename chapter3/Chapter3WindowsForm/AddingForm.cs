//This form is for adding 2 numbers
//Author: Mark McFadden

using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdditionForm : Form
    {
        public AdditionForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblSum.Visible = true;
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            int sum = num1 + num2;
            lblSum.Text = String.Format("The sum is {0}", sum.ToString("C"));
        }
    }
}
