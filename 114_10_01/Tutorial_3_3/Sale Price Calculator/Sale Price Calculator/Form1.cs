using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 加入計算特價
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            // 原價和折扣%轉換為demical
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // 計算特價
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            // 顯示特價格式化為貨幣形式
            salePriceLabel.Text = salePrice.ToString("C");

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
