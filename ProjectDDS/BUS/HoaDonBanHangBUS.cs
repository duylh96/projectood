using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDDS.DAO;

namespace ProjectDDS.BUS
{
    public class HoaDonBanHangBUS
    {
        public static bool ThemHoaDon(HOADONBANHANG hd, ref int id)
        {
            return HoaDonBanHangDAO.ThemHoaDon(hd, ref id);
        }

        public static bool CapNhatTongTienHD(int id, decimal tt, ref decimal result)
        {
            return HoaDonBanHangDAO.CapNhatTongTienHD(id, tt, ref result);
        }
    }
}
