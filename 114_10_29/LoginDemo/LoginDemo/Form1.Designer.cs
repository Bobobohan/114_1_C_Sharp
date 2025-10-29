namespace LoginDemo
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
            label_account = new Label();
            label_passsword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_account
            // 
            label_account.AutoSize = true;
            label_account.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label_account.Location = new Point(59, 60);
            label_account.Name = "label_account";
            label_account.Size = new Size(100, 46);
            label_account.TabIndex = 0;
            label_account.Text = "帳號:";
            // 
            // label_passsword
            // 
            label_passsword.AutoSize = true;
            label_passsword.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label_passsword.Location = new Point(59, 138);
            label_passsword.Name = "label_passsword";
            label_passsword.Size = new Size(100, 46);
            label_passsword.TabIndex = 1;
            label_passsword.Text = "密碼:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 30);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.Location = new Point(201, 223);
            button1.Name = "button1";
            button1.Size = new Size(142, 80);
            button1.TabIndex = 4;
            button1.Text = "檢查";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 580);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_passsword);
            Controls.Add(label_account);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_account;
        private Label label_passsword;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
