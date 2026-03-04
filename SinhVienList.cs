using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
     public class SinhVienList
     {
        public static List<SinhVien> dsSV = new List<SinhVien> ();

        public static List<SinhVien> GetAll()
        {
            return dsSV;
        }

        public static bool Them(SinhVien sv)
        {
            dsSV.Add(sv);
            return true;
        }

        public static bool Sua(SinhVien sv)
        {
            var old = dsSV.FirstOrDefault(x => x.svID == sv.svID);
            if (old == null) return false;

            old.svName = sv.svName;
            old.svClass = sv.svClass;
            old.svScore = sv.svScore;
            old.svDoB = sv.svDoB;
            return true;
        }

        public static bool Xoa(String svID)
        {
            var sv = dsSV.FirstOrDefault(x => x.svID == svID);
            if (sv == null) return false;

            dsSV.Remove(sv);
            return true;
        }
    }
}
