namespace QLSV
{
    partial class formAdd
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtsvID = new TextBox();
            txtsvName = new TextBox();
            txtsvClass = new TextBox();
            txtsvScore = new TextBox();
            dtpsvDoB = new DateTimePicker();
            btnAdd_FA = new Button();
            btnCancel_FA = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 67);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 123);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 185);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 67);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 3;
            label4.Text = "Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 123);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 4;
            label5.Text = "Điểm";
            // 
            // txtsvID
            // 
            txtsvID.Location = new Point(184, 64);
            txtsvID.Name = "txtsvID";
            txtsvID.Size = new Size(173, 27);
            txtsvID.TabIndex = 5;
            // 
            // txtsvName
            // 
            txtsvName.Location = new Point(184, 123);
            txtsvName.Name = "txtsvName";
            txtsvName.Size = new Size(173, 27);
            txtsvName.TabIndex = 6;
            // 
            // txtsvClass
            // 
            txtsvClass.Location = new Point(524, 64);
            txtsvClass.Name = "txtsvClass";
            txtsvClass.Size = new Size(173, 27);
            txtsvClass.TabIndex = 8;
            // 
            // txtsvScore
            // 
            txtsvScore.Location = new Point(524, 120);
            txtsvScore.Name = "txtsvScore";
            txtsvScore.Size = new Size(173, 27);
            txtsvScore.TabIndex = 9;
            // 
            // dtpsvDoB
            // 
            dtpsvDoB.CustomFormat = "dd/MM/yyyy";
            dtpsvDoB.Format = DateTimePickerFormat.Custom;
            dtpsvDoB.Location = new Point(184, 185);
            dtpsvDoB.MaxDate = new DateTime(2026, 1, 18, 0, 0, 0, 0);
            dtpsvDoB.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpsvDoB.Name = "dtpsvDoB";
            dtpsvDoB.Size = new Size(173, 27);
            dtpsvDoB.TabIndex = 10;
            dtpsvDoB.Value = new DateTime(2026, 1, 18, 0, 0, 0, 0);
            // 
            // btnAdd_FA
            // 
            btnAdd_FA.Location = new Point(184, 312);
            btnAdd_FA.Name = "btnAdd_FA";
            btnAdd_FA.Size = new Size(94, 29);
            btnAdd_FA.TabIndex = 11;
            btnAdd_FA.Text = "Thêm";
            btnAdd_FA.UseVisualStyleBackColor = true;
            btnAdd_FA.Click += btnAdd_FA_Click;
            // 
            // btnCancel_FA
            // 
            btnCancel_FA.Location = new Point(458, 312);
            btnCancel_FA.Name = "btnCancel_FA";
            btnCancel_FA.Size = new Size(94, 29);
            btnCancel_FA.TabIndex = 12;
            btnCancel_FA.Text = "Hủy";
            btnCancel_FA.UseVisualStyleBackColor = true;
            btnCancel_FA.Click += btnCancel_FA_Click;
            // 
            // formAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel_FA);
            Controls.Add(btnAdd_FA);
            Controls.Add(dtpsvDoB);
            Controls.Add(txtsvScore);
            Controls.Add(txtsvClass);
            Controls.Add(txtsvName);
            Controls.Add(txtsvID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAdd";
            Text = "Thêm mới sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtsvID;
        private TextBox txtsvName;
        private TextBox txtsvClass;
        private TextBox txtsvScore;
        private DateTimePicker dtpsvDoB;
        private Button btnAdd_FA;
        private Button btnCancel_FA;
    }
}