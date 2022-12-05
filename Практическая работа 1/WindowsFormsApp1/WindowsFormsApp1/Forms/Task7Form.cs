using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Task7Form : Form
    {
        public double xValue = 0;
        public double yValue = 0;

        public Task7Form()
        {
            InitializeComponent();
        }

        private void xInput_TextChanged(object sender, EventArgs e)
        {
            xValue = double.Parse(xInput.Text);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var z = Math.Log(xValue - yValue) - xValue / yValue;
            resultLabel.Text = z.ToString();
        }

        private void yInput_TextChanged(object sender, EventArgs e)
        {
            yValue = double.Parse(yInput.Text);
        }

        private void Task7Form_Load(object sender, EventArgs e)
        {

        }
    }
}
