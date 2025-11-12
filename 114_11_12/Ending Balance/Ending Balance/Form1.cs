using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m;   // 每月利率0.5%

            decimal startingBalance;                // 使用者輸入的起始餘額
            int months;                             // 使用著輸入的月份數量
            int count = 1;                          // 用於追蹤當前月份的計數器

            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0)
                {
                    while (count <= months)
                    {
                        // 計算每月結餘
                        startingBalance *=  (1 + INTEREST_RATE);

                        // 將當月詳細資訊加入清單框
                        detailListBox.Items.Add($"第 {count} 個月結餘: {startingBalance:C2}");
                        count ++;
                    }
                    endingBalanceLabel.Text = startingBalance.ToString("C2");   // 顯示最終餘額
                }
                else
                {
                    MessageBox.Show("請輸入有效的月份數量 (正整數)。", "輸入錯誤:");
                    count += count + 1;
                }

            }
            else
            {
                MessageBox.Show("請輸入有效的起始餘額", "輸入錯誤");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBoxes 和 endingBalanceLabel 控制項的內容。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 重設焦點。
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
