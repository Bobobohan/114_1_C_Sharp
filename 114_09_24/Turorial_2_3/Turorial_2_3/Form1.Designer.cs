namespace Turorial_2_3
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
            label_translation = new Label();
            btn_italian = new Button();
            btn_spanish = new Button();
            btn_germany = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(110, 58);
            label1.Name = "label1";
            label1.Size = new Size(543, 91);
            label1.TabIndex = 0;
            label1.Text = "選擇語言說早安";
            // 
            // label_translation
            // 
            label_translation.BackColor = SystemColors.Control;
            label_translation.BorderStyle = BorderStyle.Fixed3D;
            label_translation.Font = new Font("Microsoft JhengHei UI", 26F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label_translation.Location = new Point(234, 199);
            label_translation.Name = "label_translation";
            label_translation.Size = new Size(287, 108);
            label_translation.TabIndex = 1;
            // 
            // btn_italian
            // 
            btn_italian.Font = new Font("標楷體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_italian.Location = new Point(50, 356);
            btn_italian.Name = "btn_italian";
            btn_italian.Size = new Size(172, 77);
            btn_italian.TabIndex = 2;
            btn_italian.Text = "義大利文";
            btn_italian.UseVisualStyleBackColor = true;
            btn_italian.Click += btn_italian_Click;
            // 
            // btn_spanish
            // 
            btn_spanish.Font = new Font("標楷體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_spanish.Location = new Point(276, 356);
            btn_spanish.Name = "btn_spanish";
            btn_spanish.Size = new Size(172, 77);
            btn_spanish.TabIndex = 3;
            btn_spanish.Text = "西班牙文";
            btn_spanish.UseVisualStyleBackColor = true;
            btn_spanish.Click += btn_spanish_Click;
            // 
            // btn_germany
            // 
            btn_germany.Font = new Font("標楷體", 18F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_germany.Location = new Point(501, 356);
            btn_germany.Name = "btn_germany";
            btn_germany.Size = new Size(172, 77);
            btn_germany.TabIndex = 4;
            btn_germany.Text = "德文";
            btn_germany.UseVisualStyleBackColor = true;
            btn_germany.Click += btn_germany_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 572);
            Controls.Add(btn_germany);
            Controls.Add(btn_spanish);
            Controls.Add(btn_italian);
            Controls.Add(label_translation);
            Controls.Add(label1);
            Name = "Form1";
            Text = "語言翻譯器";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_translation;
        private Button btn_italian;
        private Button btn_spanish;
        private Button btn_germany;
    }
}
