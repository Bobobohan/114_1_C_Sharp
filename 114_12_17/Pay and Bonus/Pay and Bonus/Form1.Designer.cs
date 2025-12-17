namespace Pay_and_Bonus
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
            this.grossPayPromptLabel = new System.Windows.Forms.Label();
            this.bonusPromptLabel = new System.Windows.Forms.Label();
            this.grossPayTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.contributionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grossPayPromptLabel
            // 
            this.grossPayPromptLabel.AutoSize = true;
            this.grossPayPromptLabel.Location = new System.Drawing.Point(121, 34);
            this.grossPayPromptLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.grossPayPromptLabel.Name = "grossPayPromptLabel";
            this.grossPayPromptLabel.Size = new System.Drawing.Size(216, 32);
            this.grossPayPromptLabel.TabIndex = 0;
            this.grossPayPromptLabel.Text = "Total Gross Pay:";
            // 
            // bonusPromptLabel
            // 
            this.bonusPromptLabel.AutoSize = true;
            this.bonusPromptLabel.Location = new System.Drawing.Point(140, 98);
            this.bonusPromptLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.bonusPromptLabel.Name = "bonusPromptLabel";
            this.bonusPromptLabel.Size = new System.Drawing.Size(205, 32);
            this.bonusPromptLabel.TabIndex = 1;
            this.bonusPromptLabel.Text = "Bonus Amount:";
            // 
            // grossPayTextBox
            // 
            this.grossPayTextBox.Location = new System.Drawing.Point(382, 25);
            this.grossPayTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.grossPayTextBox.Name = "grossPayTextBox";
            this.grossPayTextBox.Size = new System.Drawing.Size(276, 46);
            this.grossPayTextBox.TabIndex = 2;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(382, 89);
            this.bonusTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(276, 46);
            this.bonusTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(26, 199);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(313, 32);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Retirement Contribution:";
            // 
            // contributionLabel
            // 
            this.contributionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contributionLabel.Location = new System.Drawing.Point(382, 187);
            this.contributionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.contributionLabel.Name = "contributionLabel";
            this.contributionLabel.Size = new System.Drawing.Size(280, 54);
            this.contributionLabel.TabIndex = 5;
            this.contributionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(132, 274);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(212, 96);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Contribution";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(363, 274);
            this.exitButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(212, 96);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 405);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.contributionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.grossPayTextBox);
            this.Controls.Add(this.bonusPromptLabel);
            this.Controls.Add(this.grossPayPromptLabel);
            this.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Pay and Bonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label grossPayPromptLabel;
        private System.Windows.Forms.Label bonusPromptLabel;
        private System.Windows.Forms.TextBox grossPayTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label contributionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

