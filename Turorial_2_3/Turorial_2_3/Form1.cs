namespace Turorial_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_italian_Click(object sender, EventArgs e)
        {
            label_translation.Text = "Buongiorno";
        }

        private void btn_spanish_Click(object sender, EventArgs e)
        {
            label_translation.Text = "Buenos dias";
        }

        private void btn_germany_Click(object sender, EventArgs e)
        {
            label_translation.Text = "guten Morgen";
        }
    }
}
