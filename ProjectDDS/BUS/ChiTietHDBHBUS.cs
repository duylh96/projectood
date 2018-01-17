using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDDS.DAO;

namespace ProjectDDS.BUS
{
    public class ChiTietHDBHBUS
    {
        public static bool ThemChiTietHD(CHITIETHOADONBANHANG ct, ref decimal result)
        {
            return ChiTietHDBHDAO.ThemChiTietHD(ct, ref result);
        }

        public static bool XoaChiTietHD(int id1, string id2, ref decimal result)
        {
            return ChiTietHDBHDAO.XoaChiTietHD(id1, id2, ref result);
        }

        public static bool CapNhatChiTietHD(int id1, string id2, CHITIETHOADONBANHANG ctNew, ref decimal deltaTT)
        {
            return ChiTietHDBHDAO.CapNhatChiTietHD(id1, id2, ctNew, ref deltaTT);
        }
    }
}
