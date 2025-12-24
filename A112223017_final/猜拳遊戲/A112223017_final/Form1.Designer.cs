namespace A112223017_final
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
            labelComputer = new Label();
            labelPlayer = new Label();
            btnStone = new Button();
            btnPaper = new Button();
            btnScissor = new Button();
            btnEnd = new Button();
            pictureBox_computer = new PictureBox();
            pictureBox_player = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_player).BeginInit();
            SuspendLayout();
            // 
            // labelComputer
            // 
            labelComputer.AutoSize = true;
            labelComputer.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            labelComputer.Location = new Point(132, 74);
            labelComputer.Name = "labelComputer";
            labelComputer.Size = new Size(142, 50);
            labelComputer.TabIndex = 0;
            labelComputer.Text = "電腦出";
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            labelPlayer.Location = new Point(540, 74);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(142, 50);
            labelPlayer.TabIndex = 1;
            labelPlayer.Text = "玩家出";
            // 
            // btnStone
            // 
            btnStone.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnStone.Location = new Point(124, 450);
            btnStone.Name = "btnStone";
            btnStone.Size = new Size(150, 86);
            btnStone.TabIndex = 3;
            btnStone.Text = "石頭";
            btnStone.UseVisualStyleBackColor = true;
            btnStone.Click += btnStone_Click;
            // 
            // btnPaper
            // 
            btnPaper.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnPaper.Location = new Point(355, 450);
            btnPaper.Name = "btnPaper";
            btnPaper.Size = new Size(150, 86);
            btnPaper.TabIndex = 4;
            btnPaper.Text = "布";
            btnPaper.UseVisualStyleBackColor = true;
            btnPaper.Click += btnPaper_Click;
            // 
            // btnScissor
            // 
            btnScissor.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnScissor.Location = new Point(584, 450);
            btnScissor.Name = "btnScissor";
            btnScissor.Size = new Size(150, 86);
            btnScissor.TabIndex = 5;
            btnScissor.Text = "剪刀";
            btnScissor.UseVisualStyleBackColor = true;
            btnScissor.Click += btnScissor_Click;
            // 
            // btnEnd
            // 
            btnEnd.Font = new Font("Microsoft JhengHei UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 136);
            btnEnd.Location = new Point(321, 561);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(214, 86);
            btnEnd.TabIndex = 6;
            btnEnd.Text = "結束遊戲";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // pictureBox_computer
            // 
            pictureBox_computer.Location = new Point(100, 181);
            pictureBox_computer.Name = "pictureBox_computer";
            pictureBox_computer.Size = new Size(223, 160);
            pictureBox_computer.TabIndex = 7;
            pictureBox_computer.TabStop = false;
            pictureBox_computer.Click += pictureBox_computer_Click;
            // 
            // pictureBox_player
            // 
            pictureBox_player.Location = new Point(502, 181);
            pictureBox_player.Name = "pictureBox_player";
            pictureBox_player.Size = new Size(223, 160);
            pictureBox_player.TabIndex = 8;
            pictureBox_player.TabStop = false;
            pictureBox_player.Click += pictureBox_player_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 384);
            label1.Name = "label1";
            label1.Size = new Size(61, 23);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 668);
            Controls.Add(label1);
            Controls.Add(pictureBox_player);
            Controls.Add(pictureBox_computer);
            Controls.Add(btnEnd);
            Controls.Add(btnScissor);
            Controls.Add(btnPaper);
            Controls.Add(btnStone);
            Controls.Add(labelPlayer);
            Controls.Add(labelComputer);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "猜拳遊戲";
            ((System.ComponentModel.ISupportInitialize)pictureBox_computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelComputer;
        private Label labelPlayer;
        private Button btnStone;
        private Button btnPaper;
        private Button btnScissor;
        private Button btnEnd;
        private PictureBox pictureBox_computer;
        private PictureBox pictureBox_player;
        private Label label1;
    }
}
