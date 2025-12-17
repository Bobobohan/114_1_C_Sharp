namespace Cups_To_Ounces
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
            this.bannerLabel = new System.Windows.Forms.Label();
            this.cupsPromptLabel = new System.Windows.Forms.Label();
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(50, 33);
            this.bannerLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(322, 25);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "Cups to Fluid Ounces Converter";
            // 
            // cupsPromptLabel
            // 
            this.cupsPromptLabel.AutoSize = true;
            this.cupsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cupsPromptLabel.Location = new System.Drawing.Point(235, 102);
            this.cupsPromptLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.cupsPromptLabel.Name = "cupsPromptLabel";
            this.cupsPromptLabel.Size = new System.Drawing.Size(53, 20);
            this.cupsPromptLabel.TabIndex = 1;
            this.cupsPromptLabel.Text = "Cups:";
            // 
            // cupsTextBox
            // 
            this.cupsTextBox.Location = new System.Drawing.Point(335, 94);
            this.cupsTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(179, 41);
            this.cupsTextBox.TabIndex = 2;
            // 
            // ouncesLabel
            // 
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Location = new System.Drawing.Point(335, 155);
            this.ouncesLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(182, 48);
            this.ouncesLabel.TabIndex = 3;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(140, 167);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(160, 28);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "Fluid Ounces:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(135, 252);
            this.convertButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(187, 50);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(337, 252);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(187, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 331);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.cupsPromptLabel);
            this.Controls.Add(this.bannerLabel);
            this.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form1";
            this.Text = "Cups To Ounces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label cupsPromptLabel;
        private System.Windows.Forms.TextBox cupsTextBox;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

