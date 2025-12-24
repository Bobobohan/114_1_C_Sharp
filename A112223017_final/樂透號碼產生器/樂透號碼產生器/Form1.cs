using System.Windows.Forms;

namespace 樂透號碼產生器
{
    public partial class Form1 : Form
    {
        private int[] userNumbers = new int[5];
        private int[] winningNumbers = new int[5];
        private Label[] numberLabels;

        public Form1()
        {
            InitializeComponent();

            numberLabels = new Label[] { label1, label2, label3, label4, label5 };
            label_result.Text = "請先產生號碼，再讀取檔案對獎";
            btnOpen.Enabled = false; // 須先產生號碼才能開獎
        }
       
        // 產生號碼按鈕事件        
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateRandomNumbers();

            for (int i = 0; i < 5; i++)
            {
                numberLabels[i].Text = userNumbers[i].ToString("00"); // 格式化為兩位數
                numberLabels[i].BackColor = Color.LightYellow; // 視覺回饋
            }

            label_result.Text = "號碼產生完成，請讀取開獎檔案。";
            btnOpen.Enabled = true; // 啟用開獎按鈕
        }

        
        // 開獎號碼按鈕事件 (包含檔案讀取)
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // 設定檔案對話框篩選器
            openFileDialog1.Filter = "文字檔案 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            openFileDialog1.Title = "請選擇開獎號碼檔案";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 清空 ListBox 與之前的資料
                IsWinningNumbers.Items.Clear();
                Array.Clear(winningNumbers, 0, winningNumbers.Length);

                string filePath = openFileDialog1.FileName;

                // 呼叫核心讀取方法
                if (ReadWinningNumbers(filePath))
                {
                    // 若讀取成功，進行比對
                    CompareAndShowResult();
                }
            }
        }
                        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void GenerateRandomNumbers()
        {
            Random rnd = new Random();
            int count = 0;

            // 清空舊資料
            Array.Clear(userNumbers, 0, userNumbers.Length);

            // 使用 while 迴圈直到填滿 5 個數字
            while (count < 5)
            {
                int tempNum = rnd.Next(1, 50); // 產生 1~49
                bool isDuplicate = false;

                // 檢查是否重複 (使用基本迴圈檢查)
                for (int i = 0; i < count; i++)
                {
                    if (userNumbers[i] == tempNum)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // 如果沒重複，就存入陣列
                if (!isDuplicate)
                {
                    userNumbers[count] = tempNum;
                    count++;
                }
            }

            // 為了美觀，可以選用 Array.Sort 排序 (選用)
            Array.Sort(userNumbers);
        }

        
        private bool ReadWinningNumbers(string path)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(path);
                string line;
                int index = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    // 檢查是否讀取超過 5 行
                    if (index >= 5)
                    {
                        throw new Exception("檔案格式錯誤：超過 5 個號碼。");
                    }

                    // 資料驗證與轉換
                    if (int.TryParse(line.Trim(), out int num))
                    {
                        // 檢查範圍 1-49
                        if (num < 1 || num > 49)
                        {
                            throw new Exception($"號碼 {num} 超出範圍 (1-49)。");
                        }

                        winningNumbers[index] = num;
                        IsWinningNumbers.Items.Add($"第 {index + 1} 號：{num:00}");
                        index++;
                    }
                    else
                    {
                        throw new FormatException($"第 {index + 1} 行包含非數字內容。");
                    }
                }

                // 檢查是否不足 5 行
                if (index < 5)
                {
                    throw new Exception("檔案格式錯誤：號碼不足 5 個。");
                }

                return true; // 讀取成功
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("找不到檔案！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("檔案格式錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                // 確保檔案被關閉
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
        
        private void CompareAndShowResult()
        {
            int matchCount = 0;
            string matchedNumbers = "";
                        
            for (int i = 0; i < 5; i++) // 使用者號碼迴圈
            {
                // 先重置標籤顏色
                numberLabels[i].BackColor = Color.LightYellow;

                for (int j = 0; j < 5; j++)
                {
                    if (userNumbers[i] == winningNumbers[j])
                    {
                        matchCount++;
                        matchedNumbers += userNumbers[i] + " ";

                        // 中獎的號碼標示為紅色背景，增強使用者體驗
                        numberLabels[i].BackColor = Color.LightPink;
                    }
                }
            }

            string prizeMessage = "";
            if (matchCount == 5) prizeMessage = "頭獎 (全中！)";
            else if (matchCount == 4) prizeMessage = "貳獎";
            else if (matchCount == 3) prizeMessage = "參獎";
            else if (matchCount == 2) prizeMessage = "肆獎";
            else prizeMessage = "沒中獎，再接再厲！";

            label_result.Text = $"中獎號碼數：{matchCount}\n" + $"中獎號碼：{matchedNumbers}\n" + $"結果：{prizeMessage}";
            MessageBox.Show(prizeMessage, "對獎結果", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}