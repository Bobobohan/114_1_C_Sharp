using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            decimal totalSales = 0.0m;
            decimal currentSales = 0.0m;
            string line;

            try
            {
                inputFile = File.OpenText("Saless.txt");
                listBox1.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                        listBox1.Items.Add(line);
                        currentSales[index] = currentSales;
                        index ++;
                    }
                    else
                    {
                        MessageBox.Show("Invalid data encountered in the file." + line);
                        break;
                    }
                }
                inputFile.Close();

                for (int i = 0; i < currentSales.index; i++)
                {
                    totalSales += currentSales[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
