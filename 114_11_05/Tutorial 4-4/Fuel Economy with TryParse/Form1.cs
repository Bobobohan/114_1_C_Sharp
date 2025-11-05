using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms;
            double litres;
            double fuelEconomy;

            if (double.TryParse(milesTextBox.Text, out kms))
            {
                if (double.TryParse( gallonsTextBox.Text, out litres))
                {
                    // Calculate fuel economy.
                    fuelEconomy = kms / litres;
                    // Display fuel economy.
                    mpgLabel.Text = fuelEconomy.ToString("F2") + " km/l";
                }
                else
                {
                    // Display error message.
                    MessageBox.Show("Please enter a valid numeric value for liters.", "Input Error");
                }
            }
            else
            {
                // Display error message.
                MessageBox.Show("Please enter valid numeric values for kilometers and liters.", "Input Error");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
