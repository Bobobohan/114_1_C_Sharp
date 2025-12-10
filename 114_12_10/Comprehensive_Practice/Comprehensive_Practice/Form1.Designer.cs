namespace Comprehensive_Practice
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
            label_exam1 = new Label();
            label_exam2 = new Label();
            label_exam3 = new Label();
            textBox_surname = new TextBox();
            textBox_giveName = new TextBox();
            textBox_exam1 = new TextBox();
            textBox_exam2 = new TextBox();
            textBox_exam3 = new TextBox();
            btnShowResult = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(59, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 46);
            label1.TabIndex = 0;
            label1.Text = "姓";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(293, 33);
            label2.Name = "label2";
            label2.Size = new Size(56, 46);
            label2.TabIndex = 1;
            label2.Text = "名";
            // 
            // label_exam1
            // 
            label_exam1.AutoSize = true;
            label_exam1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label_exam1.Location = new Point(59, 144);
            label_exam1.Name = "label_exam1";
            label_exam1.Size = new Size(113, 46);
            label_exam1.TabIndex = 2;
            label_exam1.Text = "小考1";
            // 
            // label_exam2
            // 
            label_exam2.AutoSize = true;
            label_exam2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label_exam2.Location = new Point(59, 214);
            label_exam2.Name = "label_exam2";
            label_exam2.Size = new Size(113, 46);
            label_exam2.TabIndex = 3;
            label_exam2.Text = "小考2";
            // 
            // label_exam3
            // 
            label_exam3.AutoSize = true;
            label_exam3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label_exam3.Location = new Point(59, 285);
            label_exam3.Name = "label_exam3";
            label_exam3.Size = new Size(113, 46);
            label_exam3.TabIndex = 4;
            label_exam3.Text = "小考3";
            // 
            // textBox_surname
            // 
            textBox_surname.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox_surname.Location = new Point(121, 33);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(139, 53);
            textBox_surname.TabIndex = 5;
            // 
            // textBox_giveName
            // 
            textBox_giveName.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox_giveName.Location = new Point(355, 33);
            textBox_giveName.Name = "textBox_giveName";
            textBox_giveName.Size = new Size(139, 53);
            textBox_giveName.TabIndex = 6;
            // 
            // textBox_exam1
            // 
            textBox_exam1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox_exam1.Location = new Point(210, 137);
            textBox_exam1.Name = "textBox_exam1";
            textBox_exam1.Size = new Size(161, 53);
            textBox_exam1.TabIndex = 7;
            // 
            // textBox_exam2
            // 
            textBox_exam2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox_exam2.Location = new Point(210, 207);
            textBox_exam2.Name = "textBox_exam2";
            textBox_exam2.Size = new Size(161, 53);
            textBox_exam2.TabIndex = 8;
            // 
            // textBox_exam3
            // 
            textBox_exam3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox_exam3.Location = new Point(210, 278);
            textBox_exam3.Name = "textBox_exam3";
            textBox_exam3.Size = new Size(161, 53);
            textBox_exam3.TabIndex = 9;
            // 
            // btnShowResult
            // 
            btnShowResult.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btnShowResult.Location = new Point(335, 351);
            btnShowResult.Name = "btnShowResult";
            btnShowResult.Size = new Size(212, 84);
            btnShowResult.TabIndex = 10;
            btnShowResult.Text = "顯示最高分";
            btnShowResult.UseVisualStyleBackColor = true;
            btnShowResult.Click += btnShowResult_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(562, 354);
            button1.Name = "button1";
            button1.Size = new Size(212, 84);
            button1.TabIndex = 11;
            button1.Text = "離開";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnShowResult);
            Controls.Add(textBox_exam3);
            Controls.Add(textBox_exam2);
            Controls.Add(textBox_exam1);
            Controls.Add(textBox_giveName);
            Controls.Add(textBox_surname);
            Controls.Add(label_exam3);
            Controls.Add(label_exam2);
            Controls.Add(label_exam1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label_exam1;
        private Label label_exam2;
        private Label label_exam3;
        private TextBox textBox_surname;
        private TextBox textBox_giveName;
        private TextBox textBox_exam1;
        private TextBox textBox_exam2;
        private TextBox textBox_exam3;
        private Button btnShowResult;
        private Button button1;
    }
}
