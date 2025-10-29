namespace MultipleConditionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try 
            {
                int grade = int.Parse(textBox1.Text);
                string level;
                if (grade >= 90)
                {
                    level = "優等";
                }
                else if (grade >= 80)   // score <90 是隱含的條件
                {
                    level = "甲等";
                }
                else if (grade >= 70)   // score <80 是隱含的條件
                {
                    level = "乙等";
                }
                else if (grade >= 60)   // score <70 是隱含的條件
                {
                    level = "丙等";
                }
                else
                {
                    level = "丁等";
                }
                textBox2.Text = level;
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
