using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Task16Form : Form
    {
        private double circleRadius = 0;
        private double squareLenght = 0;

        public Task16Form()
        {
            InitializeComponent();
        }

        private bool isFit()
        {
            return circleRadius * 2 <= squareLenght;
        }

        private void circleInput_TextChanged(object sender, EventArgs e)
        {
            double S = Double.Parse(circleInput.Text);
            circleRadius = Math.Sqrt(S / Math.PI);
        }

        private void squareInput_TextChanged(object sender, EventArgs e)
        {
            double S = Double.Parse(squareInput.Text);
            squareLenght = Math.Sqrt(S);
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            answerLabel.Text = isFit() ? "Yes" : "No";
        }
    }
}
