namespace LoginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String account = textBox1.Text;
            String password = textBox2.Text;

            //if (account == "admin" && password == "password")
            //{
            //    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Invalid account or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (account.Length == 0 || password.Length == 0)
            {
                
            }
        }
    }
}
