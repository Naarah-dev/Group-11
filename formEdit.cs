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
    public partial class formEdit : Form
    {
        SinhVien svTemp = new SinhVien();
        public formEdit(SinhVien sv)
        {
            InitializeComponent();
            svTemp = sv;
        }

        private void formEdit_Load(object sender, EventArgs e)
        {
            txtsvID_FE.Text = svTemp.svID;
            txtsvName_FE.Text = svTemp.svName;
            txtsvClass_FE.Text = svTemp.svClass;
            txtsvScore_FE.Text = svTemp.svScore.ToString();
            DateTime doB = DateTime.ParseExact(svTemp.svDoB, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dtpsvDoB_FE.Value = doB;

            txtsvID_FE.Enabled = false;
        }

        private void btnSave_FE_Click(object sender, EventArgs e)
        {
            svTemp.svName = txtsvName_FE.Text;
            svTemp.svClass = txtsvClass_FE.Text;
            svTemp.svScore = float.Parse(txtsvScore_FE.Text);
            DateTime DoB = dtpsvDoB_FE.Value;
            svTemp.svDoB = DoB.ToString("dd/MM/yyyy");

            SinhVien1.Sua(svTemp);
            MessageBox.Show("Sửa sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_Cancel_FE_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy các thay đổi đã nhập không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
