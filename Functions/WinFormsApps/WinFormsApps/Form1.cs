namespace WinFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            // label1.Text = textBox1.Text.ToUpper() ;
            string word = textBox1.Text;
            label1.Text = word.ToUpper();

        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            // label1.Text = textBox1.Text.ToLower();
            string word = textBox1.Text;
            label1.Text = word.ToLower();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bazinga", "Welcome caption", // main messge
                MessageBoxButtons.YesNo, //different icons that can be used
                MessageBoxIcon.Information,//different icons
                MessageBoxDefaultButton.Button2, //determine which button is highlighted by default
                MessageBoxOptions.ServiceNotification) == DialogResult.No)//determines the genaral look and shape of the messege
            {
                this.Close();
            }

        }







        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}