namespace MultipleConditionDemo
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
            label_grade = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label_level = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label_grade
            // 
            label_grade.AutoSize = true;
            label_grade.Location = new Point(41, 44);
            label_grade.Name = "label_grade";
            label_grade.Size = new Size(50, 23);
            label_grade.TabIndex = 0;
            label_grade.Text = "成績:";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.Location = new Point(77, 198);
            button1.Name = "button1";
            button1.Size = new Size(184, 60);
            button1.TabIndex = 1;
            button1.Text = "成績判斷";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 30);
            textBox1.TabIndex = 2;
            // 
            // label_level
            // 
            label_level.AutoSize = true;
            label_level.Location = new Point(41, 108);
            label_level.Name = "label_level";
            label_level.Size = new Size(50, 23);
            label_level.TabIndex = 3;
            label_level.Text = "等級:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.Location = new Point(119, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 30);
            textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label_level);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label_grade);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_grade;
        private Button button1;
        private TextBox textBox1;
        private Label label_level;
        private TextBox textBox2;
    }
}
