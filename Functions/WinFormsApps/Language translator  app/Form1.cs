namespace Language_translator__app
{
    public partial class LanguageForm : Form
    {
        public LanguageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HeadLinelabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void arabiclanguageButton_Click(object sender, EventArgs e)
        {
            label1.Text = "صباح الخير";
        }

        private void spanishLanguageButton1_Click(object sender, EventArgs e)
        {
            label1.Text = "buen día";
        }

        private void GermenlanguageButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Guten Morgen";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}