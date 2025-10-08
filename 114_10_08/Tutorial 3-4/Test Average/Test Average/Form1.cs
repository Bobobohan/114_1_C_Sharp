using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 取得三個測驗分數
            double test1, test2, test3;

            try
            {
                // 將輸入文字轉換為數字
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // 計算三個平均
                double average = (test1 + test2 + test3) / 3.0;

                // 顯示平均 格式化為兩位小數並顯示在averageLabel
                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息
                MessageBox.Show("例外發生!", ex.Message);
                // Clear the input and output controls.
                test1TextBox.Text = "";
                test2TextBox.Text = "";
                test3TextBox.Text = "";
                averageLabel.Text = "";
                // 選取並聚焦在test1TextBox
                test1TextBox.Focus();
            }

        }
        
        private void clearButton_Click(object sender, EventArgs e)
        {
                      
            // Clear the input and output controls.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
