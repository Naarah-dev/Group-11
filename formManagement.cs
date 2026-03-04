namespace QLSV
{
    public partial class formManagement : Form
    {
        public formManagement()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dgvSV.DataSource = null;
            dgvSV.AutoGenerateColumns = false;
            dgvSV.DataSource = SinhVien1.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            formAdd formAdd = new formAdd();          
            formAdd.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa.","Thông báo", MessageBoxButtons.OK);
                return;
            }

            DataGridViewRow row = dgvSV.SelectedRows[0];

            SinhVien sv = new SinhVien();

            sv.svID = row.Cells["colsvID"].Value.ToString();
            sv.svName = row.Cells["colsvName"].Value.ToString();
            sv.svClass = row.Cells["colsvClass"].Value.ToString();
            sv.svDoB = row.Cells["colsvDoB"].Value.ToString();
            float diem = float.Parse(row.Cells["colsvScore"].Value.ToString());
            sv.svScore = diem;

            this.Hide();
            formEdit fe = new formEdit(sv);
            fe.ShowDialog();
            this.Show();
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvSV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.","Thông báo",MessageBoxButtons.OK);
                return;
            }

            string svID = dgvSV.CurrentRow.Cells["colsvID"].Value.ToString();

            DialogResult result = MessageBox.Show("Bạn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SinhVien1.Xoa(svID);
                LoadData();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvSV.DataSource = null;
            dgvSV.DataSource = SinhVien1.TimKiem(txtSearch.Text);
        }
    }
}

