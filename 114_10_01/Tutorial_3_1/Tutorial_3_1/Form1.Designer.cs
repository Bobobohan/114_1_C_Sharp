namespace Tutorial_3_1
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
            tbx_date = new TextBox();
            tbx_month = new TextBox();
            tbxDay = new TextBox();
            tbx_year = new TextBox();
            btn_showDate = new Button();
            label_datePutOut = new Label();
            btn_clear = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("新細明體", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(57, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 40);
            label1.TabIndex = 0;
            label1.Text = "星期:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("新細明體", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(57, 288);
            label2.Name = "label2";
            label2.Size = new Size(107, 40);
            label2.TabIndex = 1;
            label2.Text = "年份:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("新細明體", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(57, 205);
            label3.Name = "label3";
            label3.Size = new Size(107, 40);
            label3.TabIndex = 2;
            label3.Text = "日期:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("新細明體", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label4.Location = new Point(57, 124);
            label4.Name = "label4";
            label4.Size = new Size(107, 40);
            label4.TabIndex = 3;
            label4.Text = "月份:";
            // 
            // tbx_date
            // 
            tbx_date.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tbx_date.Location = new Point(201, 33);
            tbx_date.Name = "tbx_date";
            tbx_date.Size = new Size(296, 58);
            tbx_date.TabIndex = 4;
            // 
            // tbx_month
            // 
            tbx_month.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tbx_month.Location = new Point(201, 124);
            tbx_month.Name = "tbx_month";
            tbx_month.Size = new Size(296, 58);
            tbx_month.TabIndex = 5;
            // 
            // tbxDay
            // 
            tbxDay.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tbxDay.Location = new Point(201, 205);
            tbxDay.Name = "tbxDay";
            tbxDay.Size = new Size(296, 58);
            tbxDay.TabIndex = 6;
            // 
            // tbx_year
            // 
            tbx_year.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tbx_year.Location = new Point(201, 288);
            tbx_year.Name = "tbx_year";
            tbx_year.Size = new Size(296, 58);
            tbx_year.TabIndex = 7;
            // 
            // btn_showDate
            // 
            btn_showDate.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_showDate.Location = new Point(57, 565);
            btn_showDate.Name = "btn_showDate";
            btn_showDate.Size = new Size(176, 69);
            btn_showDate.TabIndex = 8;
            btn_showDate.Text = "顯示日期";
            btn_showDate.UseVisualStyleBackColor = true;
            btn_showDate.Click += btn_showDate_Click;
            // 
            // label_datePutOut
            // 
            label_datePutOut.BorderStyle = BorderStyle.Fixed3D;
            label_datePutOut.Location = new Point(45, 402);
            label_datePutOut.Name = "label_datePutOut";
            label_datePutOut.Size = new Size(551, 116);
            label_datePutOut.TabIndex = 9;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_clear.Location = new Point(278, 565);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(176, 69);
            btn_clear.TabIndex = 10;
            btn_clear.Text = "清除";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_exit.Location = new Point(502, 565);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(176, 69);
            btn_exit.TabIndex = 11;
            btn_exit.Text = "離開";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 698);
            Controls.Add(btn_exit);
            Controls.Add(btn_clear);
            Controls.Add(label_datePutOut);
            Controls.Add(btn_showDate);
            Controls.Add(tbx_year);
            Controls.Add(tbxDay);
            Controls.Add(tbx_month);
            Controls.Add(tbx_date);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbx_date;
        private TextBox tbx_month;
        private TextBox tbxDay;
        private TextBox tbx_year;
        private Button btn_showDate;
        private Label label_datePutOut;
        private Button btn_clear;
        private Button btn_exit;
    }
}
