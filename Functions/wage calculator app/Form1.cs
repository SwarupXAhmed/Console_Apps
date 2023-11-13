namespace wage_calculator_app
{
    public partial class WageCalculator : Form
    {
        public WageCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double hours = Convert.ToDouble(hourstextbox.Text);
            double wages = Convert.ToDouble(hourlyRatetextBox.Text);
            double grossPay = hours * wages;
            double taxRate = Convert.ToDouble(taxRatetextbox.Text);

            double netPay = grossPay * ((100 - taxRate) / 100);

            MessageBox.Show(
               netPay.ToString(), // converts the double to string
               "your net pay is",
              MessageBoxButtons.OK,
               MessageBoxIcon.Information);

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}