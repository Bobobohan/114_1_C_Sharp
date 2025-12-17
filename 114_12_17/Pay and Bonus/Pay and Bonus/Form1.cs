using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0.0m;
            decimal bonus = 0.0m;
            decimal contribution;

            if (InputIsValid(ref grossPay, ref bonus))
            {
                contribution = (grossPay + bonus) * CONTRIB_RATE;
                contributionLabel.Text = contribution.ToString("C");
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for gross pay and bonus.");
            }
        }

        private bool InputIsValid(ref decimal grossPay, ref decimal bonus)
        {
            bool inputIsValid = false;
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {                
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    inputIsValid = true;
                }
                else
                {
                    MessageBox.Show("獎金輸入無效");                    
                }
            }
            else
            {
                MessageBox.Show("薪資輸入無效");
                // InputIsValid = false;
                bonus = 0;
            }
            return inputIsValid;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
