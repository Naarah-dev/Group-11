namespace QLSV
{
    partial class formEdit
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
            txtsvID_FE = new TextBox();
            txtsvName_FE = new TextBox();
            txtsvClass_FE = new TextBox();
            txtsvScore_FE = new TextBox();
            dtpsvDoB_FE = new DateTimePicker();
            btnSave_FE = new Button();
            btn_Cancel_FE = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 66);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 125);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 186);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 66);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 3;
            label4.Text = "Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 125);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 4;
            label5.Text = "Điểm";
            // 
            // txtsvID_FE
            // 
            txtsvID_FE.Location = new Point(196, 63);
            txtsvID_FE.Name = "txtsvID_FE";
            txtsvID_FE.Size = new Size(155, 27);
            txtsvID_FE.TabIndex = 5;
            // 
            // txtsvName_FE
            // 
            txtsvName_FE.Location = new Point(196, 125);
            txtsvName_FE.Name = "txtsvName_FE";
            txtsvName_FE.Size = new Size(155, 27);
            txtsvName_FE.TabIndex = 6;
            // 
            // txtsvClass_FE
            // 
            txtsvClass_FE.Location = new Point(559, 66);
            txtsvClass_FE.Name = "txtsvClass_FE";
            txtsvClass_FE.Size = new Size(155, 27);
            txtsvClass_FE.TabIndex = 7;
            // 
            // txtsvScore_FE
            // 
            txtsvScore_FE.Location = new Point(559, 122);
            txtsvScore_FE.Name = "txtsvScore_FE";
            txtsvScore_FE.Size = new Size(155, 27);
            txtsvScore_FE.TabIndex = 8;
            // 
            // dtpsvDoB_FE
            // 
            dtpsvDoB_FE.CustomFormat = "dd/MM/yyyy";
            dtpsvDoB_FE.Format = DateTimePickerFormat.Custom;
            dtpsvDoB_FE.Location = new Point(196, 186);
            dtpsvDoB_FE.MaxDate = new DateTime(2026, 1, 18, 0, 0, 0, 0);
            dtpsvDoB_FE.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpsvDoB_FE.Name = "dtpsvDoB_FE";
            dtpsvDoB_FE.Size = new Size(155, 27);
            dtpsvDoB_FE.TabIndex = 9;
            dtpsvDoB_FE.Value = new DateTime(2026, 1, 18, 0, 0, 0, 0);
            // 
            // btnSave_FE
            // 
            btnSave_FE.Location = new Point(196, 320);
            btnSave_FE.Name = "btnSave_FE";
            btnSave_FE.Size = new Size(94, 29);
            btnSave_FE.TabIndex = 10;
            btnSave_FE.Text = "Lưu";
            btnSave_FE.UseVisualStyleBackColor = true;
            btnSave_FE.Click += btnSave_FE_Click;
            // 
            // btn_Cancel_FE
            // 
            btn_Cancel_FE.Location = new Point(494, 320);
            btn_Cancel_FE.Name = "btn_Cancel_FE";
            btn_Cancel_FE.Size = new Size(94, 29);
            btn_Cancel_FE.TabIndex = 11;
            btn_Cancel_FE.Text = "Hủy";
            btn_Cancel_FE.UseVisualStyleBackColor = true;
            btn_Cancel_FE.Click += btn_Cancel_FE_Click;
            // 
            // formEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Cancel_FE);
            Controls.Add(btnSave_FE);
            Controls.Add(dtpsvDoB_FE);
            Controls.Add(txtsvScore_FE);
            Controls.Add(txtsvClass_FE);
            Controls.Add(txtsvName_FE);
            Controls.Add(txtsvID_FE);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formEdit";
            Text = "Sửa thông tin sinh viên";
            Load += formEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtsvID_FE;
        private TextBox txtsvName_FE;
        private TextBox txtsvClass_FE;
        private TextBox txtsvScore_FE;
        private DateTimePicker dtpsvDoB_FE;
        private Button btnSave_FE;
        private Button btn_Cancel_FE;
    }
}