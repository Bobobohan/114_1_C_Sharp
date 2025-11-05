namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String message = "點餐內容 ";
            String drink = "";
            String sandwich = "";

            // 飲料部分
            if (radioButton1.Checked)
            {
                drink = "咖啡 ";
            }
            else if (radioButton2.Checked)
            {
                drink = "奶茶 ";
            }
            else if (radioButton3.Checked)
            {
                drink = "紅茶 ";
            }
            else if (radioButton4.Checked)
            {
                drink = "果汁 ";
            }
            else
            {
                drink = "";
            }

            // 三明治部分
            if (radioButton5.Checked)
            {
                sandwich = "火腿蛋吐司 ";
            }
            else if (radioButton6.Checked)
            {
                sandwich = "培根蛋吐司 ";
            }
            else if (radioButton7.Checked)
            {
                sandwich = "總匯三明治 ";
            }
            else
            {
                sandwich = "";
            }

            message = drink + sandwich;
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
