namespace 汽車維修服務管理系統
{
    public partial class Form1 : Form
    {
        // 定義費用常數
        private const decimal OIL_CHANGE_PRICE = 780m;
        private const decimal LUBE_JOB_PRICE = 540m;
        private const decimal RADIATOR_FLUSH_PRICE = 900m;
        private const decimal TRANSMISSION_FLUSH_PRICE = 2400m;
        private const decimal INSPECTION_PRICE = 450m;
        private const decimal MUFFLER_PRICE = 3000m;
        private const decimal TIRE_ROTATION_PRICE = 600m;

        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal TAX_RATE = 0.06m;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 取得並驗證零件與工時輸入
            decimal partsCost = 0m;
            decimal laborHours = 0m;

            if (!ValidateInput(out partsCost, out laborHours))
            {
                return; // 驗證失敗，中止計算
            }

            // 呼叫各個計算方法
            decimal oilLubeCost = OilLubeCharges();
            decimal flushCost = FlushCharges();
            decimal miscCost = MiscCharges();
            decimal laborCost = OtherCharges(laborHours); // 計算工資
            decimal serviceAndLaborTotal = oilLubeCost + flushCost + miscCost + laborCost;
            decimal taxCost = TaxCharges(partsCost); // 僅針對零件計算稅金
            decimal totalCost = TotalCharges(serviceAndLaborTotal, partsCost, taxCost);

            // 更新介面顯示 (格式化為貨幣 C0: 不顯示小數點, C2: 顯示兩位小數)
            lblServiceLaborCost.Text = serviceAndLaborTotal.ToString("C0");
            lblPartsCost.Text = partsCost.ToString("C0");
            lblTaxCost.Text = taxCost.ToString("C0");
            lblTotalCost.Text = totalCost.ToString("C0");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 詢問是否要儲存報表
            DialogResult result = MessageBox.Show(
                "在離開前，是否要將維修明細儲存為檔案？",
                "儲存確認",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 先執行計算以確保數據最新（防止使用者更改選項後未計算直接存檔）
                calculateButton.PerformClick();

                if (SaveServiceDetailsToFile())
                {
                    Application.Exit();
                }
                // 如果存檔失敗或取消，則不關閉程式，讓使用者決定
            }
            else if (result == DialogResult.No)
            {
                Application.Exit();
            }
            // Cancel 則不做任何事
        }

        // ==========================================
        // 費用計算方法 (Calculation Methods)
        // ==========================================

        private decimal OilLubeCharges()
        {
            decimal cost = 0m;
            if (chkOilChange.Checked) cost += OIL_CHANGE_PRICE;
            if (chkLubeJob.Checked) cost += LUBE_JOB_PRICE;
            return cost;
        }

        private decimal FlushCharges()
        {
            decimal cost = 0m;
            if (chkRadiatorFlush.Checked) cost += RADIATOR_FLUSH_PRICE;
            if (chkTransmissionFlush.Checked) cost += TRANSMISSION_FLUSH_PRICE;
            return cost;
        }

        private decimal MiscCharges()
        {
            decimal cost = 0m;
            if (chkInspection.Checked) cost += INSPECTION_PRICE;
            if (chkMuffler.Checked) cost += MUFFLER_PRICE;
            if (chkTireRotation.Checked) cost += TIRE_ROTATION_PRICE;
            return cost;
        }

        /// <summary>
        /// 計算工時費用
        /// </summary>
        private decimal OtherCharges(decimal hours)
        {
            return hours * LABOR_RATE_PER_HOUR;
        }

        /// <summary>
        /// 計算稅金 (僅零件)
        /// </summary>
        private decimal TaxCharges(decimal parts)
        {
            return parts * TAX_RATE;
        }

        /// <summary>
        /// 計算總費用
        /// </summary>
        private decimal TotalCharges(decimal serviceLabor, decimal parts, decimal tax)
        {
            return serviceLabor + parts + tax;
        }

        // ==========================================
        // 資料清除方法 (Clear Methods)
        // ==========================================

        private void ClearOilLube()
        {
            chkOilChange.Checked = false;
            chkLubeJob.Checked = false;
        }

        private void ClearFlushes()
        {
            chkRadiatorFlush.Checked = false;
            chkTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            chkInspection.Checked = false;
            chkMuffler.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            txtParts.Text = "";
            txtLabor.Text = "";
        }

        private void ClearFees()
        {
            lblServiceLaborCost.Text = "";
            lblPartsCost.Text = "";
            lblTaxCost.Text = "";
            lblTotalCost.Text = "";
        }

        // ==========================================
        // 輔助與檔案處理方法 (Helper & File I/O)
        // ==========================================

        /// <summary>
        /// 驗證使用者輸入的數值
        /// </summary>
        private bool ValidateInput(out decimal parts, out decimal labor)
        {
            parts = 0m;
            labor = 0m;

            // 處理零件費用輸入
            if (!string.IsNullOrWhiteSpace(txtParts.Text))
            {
                if (!decimal.TryParse(txtParts.Text, out parts) || parts < 0)
                {
                    MessageBox.Show("零件費用必須為有效的正數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtParts.Focus();
                    return false;
                }
            }

            // 處理工時輸入
            if (!string.IsNullOrWhiteSpace(txtLabor.Text))
            {
                if (!decimal.TryParse(txtLabor.Text, out labor) || labor < 0)
                {
                    MessageBox.Show("工時必須為有效的正數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLabor.Focus();
                    return false;
                }
            }

            return true;
        }

        private bool SaveServiceDetailsToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文字檔案 (*.txt)|*.txt";
            saveFileDialog.Title = "儲存維修明細";
            saveFileDialog.FileName = $"維修單_{DateTime.Now:yyyyMMdd_HHmm}.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = null;
                try
                {
                    writer = File.CreateText(saveFileDialog.FileName);

                    // 寫入報表檔頭
                    writer.WriteLine("========================================");
                    writer.WriteLine("         汽車維修服務明細表");
                    writer.WriteLine("========================================");
                    writer.WriteLine($"日期: {DateTime.Now}");
                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine("【服務項目】");

                    // 寫入已選項目
                    if (chkOilChange.Checked) writer.WriteLine($" - 更換機油: {OIL_CHANGE_PRICE:C0}");
                    if (chkLubeJob.Checked) writer.WriteLine($" - 潤滑保養: {LUBE_JOB_PRICE:C0}");
                    if (chkRadiatorFlush.Checked) writer.WriteLine($" - 水箱清洗: {RADIATOR_FLUSH_PRICE:C0}");
                    if (chkTransmissionFlush.Checked) writer.WriteLine($" - 變速箱清洗: {TRANSMISSION_FLUSH_PRICE:C0}");
                    if (chkInspection.Checked) writer.WriteLine($" - 檢驗: {INSPECTION_PRICE:C0}");
                    if (chkMuffler.Checked) writer.WriteLine($" - 更換消音器: {MUFFLER_PRICE:C0}");
                    if (chkTireRotation.Checked) writer.WriteLine($" - 輪胎換位: {TIRE_ROTATION_PRICE:C0}");

                    // 取得數值用於寫入
                    decimal parts = 0, labor = 0;
                    ValidateInput(out parts, out labor); // 這裡假設已經驗證過

                    if (labor > 0) writer.WriteLine($" - 工時費用 ({labor}小時): {(labor * LABOR_RATE_PER_HOUR):C0}");

                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine("【費用統計】");
                    writer.WriteLine($" 服務與工資總計: {lblServiceLaborCost.Text}");
                    writer.WriteLine($" 零件費用:       {parts:C0}");
                    writer.WriteLine($" 稅金 (6%):      {lblTaxCost.Text}");
                    writer.WriteLine("----------------------------------------");
                    writer.WriteLine($" 總費用:         {lblTotalCost.Text}");
                    writer.WriteLine("========================================");
                    writer.WriteLine(" 感謝您的光臨！");

                    MessageBox.Show("檔案已成功儲存！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存檔案時發生錯誤：\n" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    if (writer != null)
                    {
                        writer.Close();
                    }
                }
            }
            return false;
        }
    }
}
