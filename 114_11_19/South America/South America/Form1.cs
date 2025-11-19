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

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            string countryName;
            try
            {
                inputFile = File.OpenText(@"C:\Users\m303\Desktop\新增資料夾\114_1_C_Sharp\114_11_19\South America");
                countriesListBox.Items.Clear();

                while(!inputFile.EndOfStream)
                {
                    countryName = inputFile.ReadLine();
                    countriesListBox.Items.Add(countryName);
                }

                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " = ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
