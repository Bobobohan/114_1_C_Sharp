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
using System.Threading;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        private int count = 1;   // 成員(全域)變數，保持計數器的值
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            int count = 1;   // 區域變數，每次典籍都會重設計數器
            StreamWriter outputFile;
            try
            {
                outputFile = File.CreateText("Friends.txt");
                outputFile.WriteLine(nameTextBox.Text);
                outputFile.Close();
            }               
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
