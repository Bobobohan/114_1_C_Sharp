using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kilometers;  //宣告公里數變數
            double litres;     //宣告公升數變數
            double kmpl;       //宣告公里/公升數變數

            //  讀取使用者輸入的公里數和公升數，並轉換成雙精度浮點數
            kilometers = double.Parse(milesTextBox.Text);
            litres = double.Parse(gallonsTextBox.Text);

            //  計算公里/公升數
            kmpl = kilometers / litres;

            //  顯示結果
            mpgLabel.Text = kmpl.ToString("n1") + " 公里/公升";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
