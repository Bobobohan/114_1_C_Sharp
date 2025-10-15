using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            //  檢查資格
            const decimal MINIMUM_SALARY = 120000m;   //  最低年薪
            const int MINIMUM_YEARS = 2;   //  最低年資

            decimal salary;   //  
            int yearsOnJob;   //  

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);   //  將輸入年薪轉換為decimal
                yearsOnJob = int.Parse(yearsTextBox.Text);   //  將輸入年資轉換為int

                //  根據年薪決定是否符合資格
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS) 
                    {
                        decisionLabel.Text = "符合資格";
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格:收入未達低標";
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合資格:收入未達低標";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the decisionLabel.
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // Reset the focus.
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
