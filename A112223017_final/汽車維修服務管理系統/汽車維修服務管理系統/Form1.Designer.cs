namespace 汽車維修服務管理系統
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
            groupBox_機油和潤滑 = new GroupBox();
            groupBox_cleaning = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtParts = new TextBox();
            txtLabor = new TextBox();
            groupBox3 = new GroupBox();
            lblServiceLaborCost = new Label();
            lblPartsCost = new Label();
            lblTaxCost = new Label();
            lblTotalCost = new Label();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            chkOilChange = new CheckBox();
            chkLubeJob = new CheckBox();
            chkRadiatorFlush = new CheckBox();
            chkTransmissionFlush = new CheckBox();
            chkInspection = new CheckBox();
            chkMuffler = new CheckBox();
            chkTireRotation = new CheckBox();
            label_fee = new Label();
            label_salery = new Label();
            groupBox_機油和潤滑.SuspendLayout();
            groupBox_cleaning.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_機油和潤滑
            // 
            groupBox_機油和潤滑.Controls.Add(chkLubeJob);
            groupBox_機油和潤滑.Controls.Add(chkOilChange);
            groupBox_機油和潤滑.Location = new Point(48, 52);
            groupBox_機油和潤滑.Name = "groupBox_機油和潤滑";
            groupBox_機油和潤滑.Size = new Size(234, 104);
            groupBox_機油和潤滑.TabIndex = 1;
            groupBox_機油和潤滑.TabStop = false;
            groupBox_機油和潤滑.Text = "機油和潤滑";
            // 
            // groupBox_cleaning
            // 
            groupBox_cleaning.Controls.Add(chkTransmissionFlush);
            groupBox_cleaning.Controls.Add(chkRadiatorFlush);
            groupBox_cleaning.Location = new Point(345, 52);
            groupBox_cleaning.Name = "groupBox_cleaning";
            groupBox_cleaning.Size = new Size(234, 104);
            groupBox_cleaning.TabIndex = 2;
            groupBox_cleaning.TabStop = false;
            groupBox_cleaning.Text = "清洗服務";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkTireRotation);
            groupBox1.Controls.Add(chkMuffler);
            groupBox1.Controls.Add(chkInspection);
            groupBox1.Location = new Point(48, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 157);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "其他服務";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_salery);
            groupBox2.Controls.Add(label_fee);
            groupBox2.Controls.Add(txtLabor);
            groupBox2.Controls.Add(txtParts);
            groupBox2.Location = new Point(345, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 157);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "零件和工時";
            // 
            // txtParts
            // 
            txtParts.Location = new Point(142, 50);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(74, 30);
            txtParts.TabIndex = 6;
            // 
            // txtLabor
            // 
            txtLabor.Location = new Point(142, 99);
            txtLabor.Name = "txtLabor";
            txtLabor.Size = new Size(74, 30);
            txtLabor.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(lblTotalCost);
            groupBox3.Controls.Add(lblTaxCost);
            groupBox3.Controls.Add(lblPartsCost);
            groupBox3.Controls.Add(lblServiceLaborCost);
            groupBox3.Location = new Point(48, 412);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(531, 242);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "費用摘要";
            // 
            // lblServiceLaborCost
            // 
            lblServiceLaborCost.AutoSize = true;
            lblServiceLaborCost.Location = new Point(19, 45);
            lblServiceLaborCost.Name = "lblServiceLaborCost";
            lblServiceLaborCost.Size = new Size(100, 23);
            lblServiceLaborCost.TabIndex = 6;
            lblServiceLaborCost.Text = "服務與工資";
            // 
            // lblPartsCost
            // 
            lblPartsCost.AutoSize = true;
            lblPartsCost.Location = new Point(19, 82);
            lblPartsCost.Name = "lblPartsCost";
            lblPartsCost.Size = new Size(46, 23);
            lblPartsCost.TabIndex = 7;
            lblPartsCost.Text = "零件";
            // 
            // lblTaxCost
            // 
            lblTaxCost.AutoSize = true;
            lblTaxCost.Location = new Point(20, 120);
            lblTaxCost.Name = "lblTaxCost";
            lblTaxCost.Size = new Size(99, 23);
            lblTaxCost.TabIndex = 7;
            lblTaxCost.Text = "稅金 (零件)";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Location = new Point(20, 159);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(64, 23);
            lblTotalCost.TabIndex = 7;
            lblTotalCost.Text = "總費用";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(68, 688);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(126, 40);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "計算總額";
            calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(236, 688);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(126, 40);
            clearButton.TabIndex = 7;
            clearButton.Text = "清除";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(408, 688);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(126, 40);
            exitButton.TabIndex = 8;
            exitButton.Text = "離開";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(157, 44);
            label7.Name = "label7";
            label7.Size = new Size(207, 34);
            label7.TabIndex = 8;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(157, 82);
            label8.Name = "label8";
            label8.Size = new Size(207, 34);
            label8.TabIndex = 9;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Location = new Point(157, 120);
            label9.Name = "label9";
            label9.Size = new Size(207, 34);
            label9.TabIndex = 9;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.Fixed3D;
            label10.Location = new Point(157, 159);
            label10.Name = "label10";
            label10.Size = new Size(207, 34);
            label10.TabIndex = 9;
            // 
            // chkOilChange
            // 
            chkOilChange.AutoSize = true;
            chkOilChange.Location = new Point(20, 29);
            chkOilChange.Name = "chkOilChange";
            chkOilChange.Size = new Size(191, 27);
            chkOilChange.TabIndex = 9;
            chkOilChange.Text = "更換機油 - NT$780";
            chkOilChange.UseVisualStyleBackColor = true;
            // 
            // chkLubeJob
            // 
            chkLubeJob.AutoSize = true;
            chkLubeJob.Location = new Point(19, 62);
            chkLubeJob.Name = "chkLubeJob";
            chkLubeJob.Size = new Size(191, 27);
            chkLubeJob.TabIndex = 10;
            chkLubeJob.Text = "潤滑保養 - NT$540";
            chkLubeJob.UseVisualStyleBackColor = true;
            // 
            // chkRadiatorFlush
            // 
            chkRadiatorFlush.AutoSize = true;
            chkRadiatorFlush.Location = new Point(6, 29);
            chkRadiatorFlush.Name = "chkRadiatorFlush";
            chkRadiatorFlush.Size = new Size(191, 27);
            chkRadiatorFlush.TabIndex = 10;
            chkRadiatorFlush.Text = "水箱清洗 - NT$900";
            chkRadiatorFlush.UseVisualStyleBackColor = true;
            // 
            // chkTransmissionFlush
            // 
            chkTransmissionFlush.AutoSize = true;
            chkTransmissionFlush.Location = new Point(6, 62);
            chkTransmissionFlush.Name = "chkTransmissionFlush";
            chkTransmissionFlush.Size = new Size(223, 27);
            chkTransmissionFlush.TabIndex = 10;
            chkTransmissionFlush.Text = "變速箱清洗 - NT$2,400";
            chkTransmissionFlush.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            chkInspection.AutoSize = true;
            chkInspection.Location = new Point(20, 43);
            chkInspection.Name = "chkInspection";
            chkInspection.Size = new Size(155, 27);
            chkInspection.TabIndex = 10;
            chkInspection.Text = "檢驗 - NT$450";
            chkInspection.UseVisualStyleBackColor = true;
            // 
            // chkMuffler
            // 
            chkMuffler.AutoSize = true;
            chkMuffler.Location = new Point(20, 76);
            chkMuffler.Name = "chkMuffler";
            chkMuffler.Size = new Size(223, 27);
            chkMuffler.TabIndex = 10;
            chkMuffler.Text = "更換消音器 - NT$3,000";
            chkMuffler.UseVisualStyleBackColor = true;
            // 
            // chkTireRotation
            // 
            chkTireRotation.AutoSize = true;
            chkTireRotation.Location = new Point(19, 109);
            chkTireRotation.Name = "chkTireRotation";
            chkTireRotation.Size = new Size(191, 27);
            chkTireRotation.TabIndex = 10;
            chkTireRotation.Text = "輪胎換位 - NT$600";
            chkTireRotation.UseVisualStyleBackColor = true;
            // 
            // label_fee
            // 
            label_fee.AutoSize = true;
            label_fee.Location = new Point(6, 50);
            label_fee.Name = "label_fee";
            label_fee.Size = new Size(134, 23);
            label_fee.TabIndex = 9;
            label_fee.Text = "零件費用 (NT$)";
            // 
            // label_salery
            // 
            label_salery.AutoSize = true;
            label_salery.Location = new Point(6, 99);
            label_salery.Name = "label_salery";
            label_salery.Size = new Size(99, 23);
            label_salery.TabIndex = 10;
            label_salery.Text = "工時 (小時)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 929);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox_cleaning);
            Controls.Add(groupBox_機油和潤滑);
            Name = "Form1";
            Text = "AutoRepairSystem";
            groupBox_機油和潤滑.ResumeLayout(false);
            groupBox_機油和潤滑.PerformLayout();
            groupBox_cleaning.ResumeLayout(false);
            groupBox_cleaning.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox_機油和潤滑;
        private GroupBox groupBox_cleaning;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtLabor;
        private TextBox txtParts;
        private GroupBox groupBox3;
        private Label label7;
        private Label lblTotalCost;
        private Label lblTaxCost;
        private Label lblPartsCost;
        private Label lblServiceLaborCost;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private CheckBox chkLubeJob;
        private CheckBox chkOilChange;
        private CheckBox chkTransmissionFlush;
        private CheckBox chkRadiatorFlush;
        private CheckBox chkTireRotation;
        private CheckBox chkMuffler;
        private CheckBox chkInspection;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label_salery;
        private Label label_fee;
    }
}
