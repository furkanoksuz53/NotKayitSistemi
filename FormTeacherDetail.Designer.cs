namespace NotKayitSistemi
{
    partial class FormTeacherDetail
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
            gbxStudent = new GroupBox();
            btnAdd = new Button();
            tbxStdSurname = new TextBox();
            tbxStdName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbxStdNum = new MaskedTextBox();
            gbxNotes = new GroupBox();
            btnUpdate = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbxNot3 = new MaskedTextBox();
            tbxNot2 = new MaskedTextBox();
            tbxNot1 = new MaskedTextBox();
            gbxClassDetail = new GroupBox();
            lblFailCount = new Label();
            lblSuccessCount = new Label();
            lblAverage = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            gbxStudent.SuspendLayout();
            gbxNotes.SuspendLayout();
            gbxClassDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gbxStudent
            // 
            gbxStudent.Controls.Add(btnAdd);
            gbxStudent.Controls.Add(tbxStdSurname);
            gbxStudent.Controls.Add(tbxStdName);
            gbxStudent.Controls.Add(label3);
            gbxStudent.Controls.Add(label2);
            gbxStudent.Controls.Add(label1);
            gbxStudent.Controls.Add(tbxStdNum);
            gbxStudent.Location = new Point(11, 12);
            gbxStudent.Name = "gbxStudent";
            gbxStudent.Size = new Size(250, 205);
            gbxStudent.TabIndex = 0;
            gbxStudent.TabStop = false;
            gbxStudent.Text = "Öğrenci Ekle";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(81, 158);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbxStdSurname
            // 
            tbxStdSurname.Location = new Point(81, 125);
            tbxStdSurname.Name = "tbxStdSurname";
            tbxStdSurname.Size = new Size(125, 27);
            tbxStdSurname.TabIndex = 2;
            // 
            // tbxStdName
            // 
            tbxStdName.Location = new Point(81, 93);
            tbxStdName.Name = "tbxStdName";
            tbxStdName.Size = new Size(125, 27);
            tbxStdName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 128);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 1;
            label3.Text = "Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 93);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 58);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Numara :";
            // 
            // tbxStdNum
            // 
            tbxStdNum.Location = new Point(81, 55);
            tbxStdNum.Mask = "000";
            tbxStdNum.Name = "tbxStdNum";
            tbxStdNum.Size = new Size(125, 27);
            tbxStdNum.TabIndex = 0;
            tbxStdNum.ValidatingType = typeof(int);
            // 
            // gbxNotes
            // 
            gbxNotes.Controls.Add(btnUpdate);
            gbxNotes.Controls.Add(label4);
            gbxNotes.Controls.Add(label5);
            gbxNotes.Controls.Add(label6);
            gbxNotes.Controls.Add(tbxNot3);
            gbxNotes.Controls.Add(tbxNot2);
            gbxNotes.Controls.Add(tbxNot1);
            gbxNotes.Location = new Point(267, 12);
            gbxNotes.Name = "gbxNotes";
            gbxNotes.Size = new Size(250, 205);
            gbxNotes.TabIndex = 4;
            gbxNotes.TabStop = false;
            gbxNotes.Text = "Sınav Notları";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(81, 158);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 124);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 1;
            label4.Text = "Sınav 3 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 89);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 1;
            label5.Text = "Sınav 2 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 58);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 1;
            label6.Text = "Sınav 1 :";
            // 
            // tbxNot3
            // 
            tbxNot3.Location = new Point(81, 121);
            tbxNot3.Mask = "00";
            tbxNot3.Name = "tbxNot3";
            tbxNot3.Size = new Size(125, 27);
            tbxNot3.TabIndex = 0;
            // 
            // tbxNot2
            // 
            tbxNot2.Location = new Point(81, 86);
            tbxNot2.Mask = "00";
            tbxNot2.Name = "tbxNot2";
            tbxNot2.Size = new Size(125, 27);
            tbxNot2.TabIndex = 0;
            // 
            // tbxNot1
            // 
            tbxNot1.Location = new Point(81, 55);
            tbxNot1.Mask = "00";
            tbxNot1.Name = "tbxNot1";
            tbxNot1.Size = new Size(125, 27);
            tbxNot1.TabIndex = 0;
            // 
            // gbxClassDetail
            // 
            gbxClassDetail.Controls.Add(lblFailCount);
            gbxClassDetail.Controls.Add(lblSuccessCount);
            gbxClassDetail.Controls.Add(lblAverage);
            gbxClassDetail.Controls.Add(label7);
            gbxClassDetail.Controls.Add(label8);
            gbxClassDetail.Controls.Add(label9);
            gbxClassDetail.Location = new Point(523, 12);
            gbxClassDetail.Name = "gbxClassDetail";
            gbxClassDetail.Size = new Size(250, 205);
            gbxClassDetail.TabIndex = 5;
            gbxClassDetail.TabStop = false;
            gbxClassDetail.Text = "Sınıf Detayı";
            // 
            // lblFailCount
            // 
            lblFailCount.AutoSize = true;
            lblFailCount.Location = new Point(115, 121);
            lblFailCount.Name = "lblFailCount";
            lblFailCount.Size = new Size(25, 20);
            lblFailCount.TabIndex = 4;
            lblFailCount.Text = "00";
            // 
            // lblSuccessCount
            // 
            lblSuccessCount.AutoSize = true;
            lblSuccessCount.Location = new Point(115, 89);
            lblSuccessCount.Name = "lblSuccessCount";
            lblSuccessCount.Size = new Size(25, 20);
            lblSuccessCount.TabIndex = 4;
            lblSuccessCount.Text = "00";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(115, 58);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(25, 20);
            lblAverage.TabIndex = 4;
            lblAverage.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 121);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 1;
            label7.Text = "Kalan Sayısı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 89);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 1;
            label8.Text = "Geçen Sayısı :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 58);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 1;
            label9.Text = "Ortalama :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 225);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(759, 213);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FormTeacherDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(gbxClassDetail);
            Controls.Add(gbxNotes);
            Controls.Add(gbxStudent);
            Name = "FormTeacherDetail";
            Text = "FormTeacherDetail";
            Load += FormTeacherDetail_Load;
            gbxStudent.ResumeLayout(false);
            gbxStudent.PerformLayout();
            gbxNotes.ResumeLayout(false);
            gbxNotes.PerformLayout();
            gbxClassDetail.ResumeLayout(false);
            gbxClassDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxStudent;
        private Button btnAdd;
        private TextBox tbxStdSurname;
        private TextBox tbxStdName;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox tbxStdNum;
        private GroupBox gbxNotes;
        private Button btnUpdate;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox tbxNot3;
        private MaskedTextBox tbxNot2;
        private MaskedTextBox tbxNot1;
        private GroupBox gbxClassDetail;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblFailCount;
        private Label lblSuccessCount;
        private Label lblAverage;
        private DataGridView dataGridView1;
    }
}