using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;
            if (cityListBox.SelectedIndex != -1)   // Ensure a city is selected.
            {
                city = cityListBox.SelectedItem.ToString();
                switch (city)
                {
                    case "New York":
                        city = "Eastern Standard Time";
                        break;
                    case "Chicago":
                        city = "Central Standard Time";
                        break;
                    case "Denver":
                        city = "Mountain Standard Time";
                        break;
                    case "Los Angeles":
                        city = "Pacific Standard Time";
                        break;
                    default:
                        MessageBox.Show("No resource");
                        return;
                }
            }
            else
            {
                MessageBox.Show("Please select a city.");
                return;
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
