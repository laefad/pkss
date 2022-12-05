using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Task19Form : Form
    {
        private double aValue;
        private double bValue;
        private double cValue;
        private double dValue;

        public Task19Form()
        {
            InitializeComponent();
        }

        private bool isFit()
        {
            return (aValue <= cValue && bValue <= dValue) || (aValue <= dValue && bValue <= cValue);
        }

        private void aInput_TextChanged(object sender, EventArgs e)
        {
            aValue = double.Parse(aInput.Text);
        }

        private void bInput_TextChanged(object sender, EventArgs e)
        {
            bValue= double.Parse(bInput.Text);
        }

        private void cInput_TextChanged(object sender, EventArgs e)
        {
            cValue= double.Parse(cInput.Text);
        }

        private void dInput_TextChanged(object sender, EventArgs e)
        {
            dValue= double.Parse(dInput.Text);
        }

        private void fitButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = isFit() ? "Yes" : "No";
        }
    }
}
