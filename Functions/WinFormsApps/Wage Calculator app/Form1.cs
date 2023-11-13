namespace Wage_Calculator_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class Wagecalculate : Form
        {
            public Wagecalculate()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                this.Close(); //closes the current form
            }

            private void calculateBtn_Click(object sender, EventArgs e)
            {
                double hours = Convert.ToDouble(hoursTextBox.Text);
                double wages = Convert.ToDouble(wageTextBox.Text);
                double grossPay = hours * wages;

                MessageBox.Show(
                    grossPay.ToString(), // converts the double to string
                    "your gross pay is",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information

                    );
            }
        }
    }
}