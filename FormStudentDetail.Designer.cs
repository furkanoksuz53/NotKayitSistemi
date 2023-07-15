namespace NotKayitSistemi
{
    partial class FormStudentDetail
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
            label1 = new Label();
            lblStdName = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblNot1 = new Label();
            lblNot2 = new Label();
            lblNot3 = new Label();
            label9 = new Label();
            lblStdNum = new Label();
            label2 = new Label();
            lblAvrg = new Label();
            label7 = new Label();
            lblStatu = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 42);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            // 
            // lblStdName
            // 
            lblStdName.AutoSize = true;
            lblStdName.Location = new Point(101, 42);
            lblStdName.Name = "lblStdName";
            lblStdName.Size = new Size(44, 20);
            lblStdName.TabIndex = 0;
            lblStdName.Text = "NULL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 108);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 0;
            label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 138);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 0;
            label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 169);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 0;
            label5.Text = "Sınav 3:";
            // 
            // lblNot1
            // 
            lblNot1.AutoSize = true;
            lblNot1.Location = new Point(100, 108);
            lblNot1.Name = "lblNot1";
            lblNot1.Size = new Size(25, 20);
            lblNot1.TabIndex = 0;
            lblNot1.Text = "00";
            // 
            // lblNot2
            // 
            lblNot2.AutoSize = true;
            lblNot2.Location = new Point(100, 138);
            lblNot2.Name = "lblNot2";
            lblNot2.Size = new Size(25, 20);
            lblNot2.TabIndex = 0;
            lblNot2.Text = "00";
            // 
            // lblNot3
            // 
            lblNot3.AutoSize = true;
            lblNot3.Location = new Point(100, 169);
            lblNot3.Name = "lblNot3";
            lblNot3.Size = new Size(25, 20);
            lblNot3.TabIndex = 0;
            lblNot3.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 76);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 0;
            label9.Text = "Numara :";
            // 
            // lblStdNum
            // 
            lblStdNum.AutoSize = true;
            lblStdNum.Location = new Point(101, 76);
            lblStdNum.Name = "lblStdNum";
            lblStdNum.Size = new Size(33, 20);
            lblStdNum.TabIndex = 0;
            lblStdNum.Text = "000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 198);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "Ortalama:";
            // 
            // lblAvrg
            // 
            lblAvrg.AutoSize = true;
            lblAvrg.Location = new Point(100, 198);
            lblAvrg.Name = "lblAvrg";
            lblAvrg.Size = new Size(25, 20);
            lblAvrg.TabIndex = 0;
            lblAvrg.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 229);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
            label7.TabIndex = 0;
            label7.Text = "Durum :";
            // 
            // lblStatu
            // 
            lblStatu.AutoSize = true;
            lblStatu.Location = new Point(100, 229);
            lblStatu.Name = "lblStatu";
            lblStatu.Size = new Size(25, 20);
            lblStatu.TabIndex = 0;
            lblStatu.Text = "00";
            // 
            // FormStudentDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 281);
            Controls.Add(lblStatu);
            Controls.Add(lblNot3);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lblAvrg);
            Controls.Add(lblNot2);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lblNot1);
            Controls.Add(label3);
            Controls.Add(lblStdNum);
            Controls.Add(label9);
            Controls.Add(lblStdName);
            Controls.Add(label1);
            Name = "FormStudentDetail";
            Text = "Öğrenci Detay";
            Load += FormStudentDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblStdName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblNot1;
        private Label lblNot2;
        private Label lblNot3;
        private Label label9;
        private Label lblStdNum;
        private Label label2;
        private Label lblAvrg;
        private Label label7;
        private Label lblStatu;
    }
}