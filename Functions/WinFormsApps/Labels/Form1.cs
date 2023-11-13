using System.Runtime.CompilerServices;

namespace Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void topLeftLabel_Click(object sender, EventArgs e)
        {



            if (topLeftLabel.Text == "")
            {
                topLeftLabel.Text = "Top Left";
            }
            else
            {
                topLeftLabel.Text = "";
            }









        }

        private void TopCemterLabel_Click(object sender, EventArgs e)
        {
            if (TopCemterLabel.Text == "")
            {

                TopCemterLabel.Text = "Top Center";
            }

            else
            {
                TopCemterLabel.Text = "";
            }
        }
        private void middleLeftLabel_Click(object sender, EventArgs e)
        {

            if (middleLeftLabel.Text == "")
            {
                middleLeftLabel.Text = "Middle Left";
            }

            else
            {
                middleLeftLabel.Text = "";
            }
        }

        private void topRightLabel_Click(object sender, EventArgs e)
        {
            if (topRightLabel.Text == "")
            {
                topRightLabel.Text = "Top Right";
            }
            else
            {
                topRightLabel.Text = "";
            }
        }

        private void middleCenterlabel_Click(object sender, EventArgs e)
        {
            if (middleCenterlabel.Text == "")
            {
                middleCenterlabel.Text = "Middle Center";
            }
            else { middleCenterlabel.Text = ""; }
        }

        private void rightMiddleLabel_Click(object sender, EventArgs e)
        {
            if (rightMiddleLabel.Text == "")
            {
                rightMiddleLabel.Text = "Middle Right";
            }
            else
            {
                rightMiddleLabel.Text = "";
            }
        }

        private void bottomLeftLabel_Click(object sender, EventArgs e)
        {
            bottomLeftLabel.Text = "Bottom Left";
        }

        private void bottomCenterLabel_Click(object sender, EventArgs e)
        {
            bottomCenterLabel.Text = "Bottom Center";
        }

        private void bottomRightLAbel_Click(object sender, EventArgs e)
        {
            bottomRightLAbel.Text = "Bottom Right";
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }
    }
}