using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Task10Form : Form
    {
        public double aValue;
        public double bValue;
        public double cValue;

        public Task10Form()
        {
            InitializeComponent();
        }

        private string getSortedValues()
        {
            double[] arr = { aValue, bValue, cValue };
            Array.Sort(arr);
            return String.Join(", ", arr);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                getSortedValues(),
                "Переменные в порядке возрастания",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
            );
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

        private void Task10Form_Load(object sender, EventArgs e)
        {

        }
    }
}
