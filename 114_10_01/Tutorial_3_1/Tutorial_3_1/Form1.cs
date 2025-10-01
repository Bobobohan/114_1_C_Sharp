namespace Tutorial_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_showDate_Click(object sender, EventArgs e)
        {
            string date = tbx_date.Text;
            string month = tbx_month.Text;
            string year = tbx_year.Text;
            string day = tbx_date.Text;

            string output = "中華民國" + year + "年" + month + "月" + date + "日" + "星期" + day;
            label_datePutOut.Text = output;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_date.Text = "";
            tbx_month.Text = "";
            tbx_year.Text = "";
            tbxDay.Text = "";
        }
    }
}
