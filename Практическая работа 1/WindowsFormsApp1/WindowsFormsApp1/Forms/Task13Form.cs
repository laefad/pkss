using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Task13Form : Form
    {
        private double x1 = 0;
        private double y1 = 0;
        private double x2 = 0;
        private double y2 = 0;
        private double x3 = 0;
        private double y3 = 0;

        public Task13Form()
        {
            InitializeComponent();
        }

        private bool isExists()
        {
            double a = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
            double b = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
            double c = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return (a + b) > c && (a + c) > b && (b + c) > a;
        }

        private void x1Input_TextChanged(object sender, EventArgs e)
        {
            x1 = double.Parse(x1Input.Text);
        }

        private void x2Input_TextChanged(object sender, EventArgs e)
        {
            x2 = double.Parse(x2Input.Text);
        }

        private void x3Input_TextChanged(object sender, EventArgs e)
        {
            x3 = double.Parse(x3Input.Text);
        }

        private void y1Input_TextChanged(object sender, EventArgs e)
        {
            y1 = double.Parse(y1Input.Text);
        }

        private void y2Input_TextChanged(object sender, EventArgs e)
        {
            y2 = double.Parse(y2Input.Text);
        }

        private void y3Input_TextChanged(object sender, EventArgs e)
        {
            y3 = double.Parse(y3Input.Text);
        }

        private void existsButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = isExists() ? "Yes" : "No";
        }

        private void Task13Form_Load(object sender, EventArgs e)
        {

        }
    }
}
