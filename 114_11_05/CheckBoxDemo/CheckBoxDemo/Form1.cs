namespace CheckBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "";

            if (checkBox1.Checked)
            {
                message = "夏威夷";
            }
            if (checkBox2.Checked)
            {
                message = "章魚燒";
            }
            if (checkBox3.Checked)
            {
                message = "綜合海鮮";
            }
            if (checkBox4.Checked)
            {
                message = "義式火腿";
            }

            if (message == "")
            {
                message = "您尚未選擇";
            }

            MessageBox.Show(message, "您選擇的口味是");
        }
    }
}
