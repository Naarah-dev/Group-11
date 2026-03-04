using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class formAdd : Form
    {
        public formAdd()
        {
            InitializeComponent();
        }
       
        private void btnAdd_FA_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.svID = txtsvID.Text;
            sv.svName = txtsvName.Text;
            sv.svClass = txtsvClass.Text;
            sv.svScore = float.Parse(txtsvScore.Text);
            DateTime DoB = dtpsvDoB.Value;
            sv.svDoB = DoB.ToString("dd/MM/yyyy");

            SinhVien1.Them(sv);

            MessageBox.Show("Thêm mới sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_FA_Click(object sender, EventArgs e)
        {
            DialogResult result =MessageBox.Show("Bạn có muốn hủy thêm mới sinh viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
