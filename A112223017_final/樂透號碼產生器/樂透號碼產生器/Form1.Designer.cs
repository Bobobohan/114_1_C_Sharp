namespace 樂透號碼產生器
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            IsWinningNumbers = new ListBox();
            btnGenerate = new Button();
            btnOpen = new Button();
            btnExit = new Button();
            label_result = new Label();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(73, 74);
            label1.Name = "label1";
            label1.Size = new Size(137, 69);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(245, 74);
            label2.Name = "label2";
            label2.Size = new Size(137, 69);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(418, 74);
            label3.Name = "label3";
            label3.Size = new Size(137, 69);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(593, 74);
            label4.Name = "label4";
            label4.Size = new Size(137, 69);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label5.Location = new Point(768, 74);
            label5.Name = "label5";
            label5.Size = new Size(137, 69);
            label5.TabIndex = 4;
            // 
            // IsWinningNumbers
            // 
            IsWinningNumbers.FormattingEnabled = true;
            IsWinningNumbers.Location = new Point(93, 306);
            IsWinningNumbers.Name = "IsWinningNumbers";
            IsWinningNumbers.Size = new Size(558, 303);
            IsWinningNumbers.TabIndex = 5;
            // 
            // btnGenerate
            // 
            btnGenerate.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnGenerate.Location = new Point(93, 193);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(193, 81);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "產生號碼";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnOpen
            // 
            btnOpen.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnOpen.Location = new Point(338, 193);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(193, 81);
            btnOpen.TabIndex = 7;
            btnOpen.Text = "開獎號碼";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnExit.Location = new Point(581, 193);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 81);
            btnExit.TabIndex = 8;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // label_result
            // 
            label_result.BorderStyle = BorderStyle.FixedSingle;
            label_result.Location = new Point(689, 311);
            label_result.Name = "label_result";
            label_result.Size = new Size(232, 195);
            label_result.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 650);
            Controls.Add(label_result);
            Controls.Add(btnExit);
            Controls.Add(btnOpen);
            Controls.Add(btnGenerate);
            Controls.Add(IsWinningNumbers);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "樂透號碼產生器";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox IsWinningNumbers;
        private Button btnGenerate;
        private Button btnOpen;
        private Button btnExit;
        private Label label_result;
        private OpenFileDialog openFileDialog1;
    }
}
