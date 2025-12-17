namespace Lottery_Numbers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.fifthLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(35, 19);
            this.firstLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(105, 50);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondLabel
            // 
            this.secondLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(155, 19);
            this.secondLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(105, 50);
            this.secondLabel.TabIndex = 1;
            this.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdLabel
            // 
            this.thirdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLabel.Location = new System.Drawing.Point(275, 19);
            this.thirdLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(105, 50);
            this.thirdLabel.TabIndex = 2;
            this.thirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fourthLabel
            // 
            this.fourthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fourthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthLabel.Location = new System.Drawing.Point(395, 19);
            this.fourthLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.fourthLabel.Name = "fourthLabel";
            this.fourthLabel.Size = new System.Drawing.Size(105, 50);
            this.fourthLabel.TabIndex = 3;
            this.fourthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fifthLabel
            // 
            this.fifthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fifthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthLabel.Location = new System.Drawing.Point(515, 19);
            this.fifthLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.fifthLabel.Name = "fifthLabel";
            this.fifthLabel.Size = new System.Drawing.Size(105, 50);
            this.fifthLabel.TabIndex = 4;
            this.fifthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(133, 112);
            this.generateButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(187, 73);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate Numbers";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(335, 112);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 73);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 213);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.fifthLabel);
            this.Controls.Add(this.fourthLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Lottery Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.Label fifthLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

