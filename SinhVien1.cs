using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class SinhVien1
    {
        public static List<SinhVien> GetAll()
        {
            return SinhVienList.GetAll();
        }

        public static bool Them(SinhVien sv)
        {
            if(String.IsNullOrEmpty(sv.svName))
                return false;
            return SinhVienList.Them(sv);
        }

        public static bool Sua(SinhVien sv)
        {
            return SinhVienList.Sua(sv);
        }

        public static bool Xoa(String svID)
        {
            return SinhVienList.Xoa(svID);
        }

        public static List<SinhVien> TimKiem(string svID)
        {
            if (string.IsNullOrEmpty(svID))
                return SinhVienList.GetAll();

            svID = svID.ToLower();

            return SinhVienList.GetAll().Where(sv => sv.svID.ToLower().Contains(svID)).ToList();
        }
    }
}
