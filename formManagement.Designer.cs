namespace QLSV
{
    partial class formManagement
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
            label2 = new Label();
            dgvSV = new DataGridView();
            colsvID = new DataGridViewTextBoxColumn();
            colsvName = new DataGridViewTextBoxColumn();
            colsvClass = new DataGridViewTextBoxColumn();
            colsvDoB = new DataGridViewTextBoxColumn();
            colsvScore = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDel = new Button();
            btnSearch = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(209, 45);
            label1.Name = "label1";
            label1.Size = new Size(347, 46);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 121);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 1;
            label2.Text = "Danh sách sinh viên";
            // 
            // dgvSV
            // 
            dgvSV.AllowUserToAddRows = false;
            dgvSV.AllowUserToDeleteRows = false;
            dgvSV.AllowUserToResizeRows = false;
            dgvSV.BackgroundColor = SystemColors.ButtonHighlight;
            dgvSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSV.Columns.AddRange(new DataGridViewColumn[] { colsvID, colsvName, colsvClass, colsvDoB, colsvScore });
            dgvSV.Location = new Point(69, 168);
            dgvSV.MultiSelect = false;
            dgvSV.Name = "dgvSV";
            dgvSV.ReadOnly = true;
            dgvSV.RowHeadersWidth = 51;
            dgvSV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSV.Size = new Size(681, 188);
            dgvSV.TabIndex = 2;
            // 
            // colsvID
            // 
            colsvID.DataPropertyName = "svID";
            colsvID.HeaderText = "Mã SV";
            colsvID.MinimumWidth = 6;
            colsvID.Name = "colsvID";
            colsvID.ReadOnly = true;
            colsvID.Width = 125;
            // 
            // colsvName
            // 
            colsvName.DataPropertyName = "svName";
            colsvName.HeaderText = "Họ tên";
            colsvName.MinimumWidth = 6;
            colsvName.Name = "colsvName";
            colsvName.ReadOnly = true;
            colsvName.Width = 125;
            // 
            // colsvClass
            // 
            colsvClass.DataPropertyName = "svClass";
            colsvClass.HeaderText = "Lớp";
            colsvClass.MinimumWidth = 6;
            colsvClass.Name = "colsvClass";
            colsvClass.ReadOnly = true;
            colsvClass.Width = 125;
            // 
            // colsvDoB
            // 
            colsvDoB.DataPropertyName = "svDoB";
            colsvDoB.HeaderText = "Ngày sinh";
            colsvDoB.MinimumWidth = 6;
            colsvDoB.Name = "colsvDoB";
            colsvDoB.ReadOnly = true;
            colsvDoB.Width = 125;
            // 
            // colsvScore
            // 
            colsvScore.DataPropertyName = "svScore";
            colsvScore.HeaderText = "Điểm";
            colsvScore.MinimumWidth = 6;
            colsvScore.Name = "colsvScore";
            colsvScore.ReadOnly = true;
            colsvScore.Width = 125;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(510, 119);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(69, 379);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(272, 379);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(478, 379);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 6;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(656, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(656, 379);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 8;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // formManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(837, 495);
            Controls.Add(btnExit);
            Controls.Add(btnSearch);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(dgvSV);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formManagement";
            Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)dgvSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvSV;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDel;
        private Button btnSearch;
        private Button btnExit;
        private DataGridViewTextBoxColumn colsvID;
        private DataGridViewTextBoxColumn colsvName;
        private DataGridViewTextBoxColumn colsvClass;
        private DataGridViewTextBoxColumn colsvDoB;
        private DataGridViewTextBoxColumn colsvScore;
    }
}
