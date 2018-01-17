using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDDS.DAO
{
    public class HoaDonBanHangDAO
    {
        public static bool ThemHoaDon(HOADONBANHANG hd, ref int id)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();
            db.HOADONBANHANGs.InsertOnSubmit(hd);

            try
            {
                db.SubmitChanges();
                id = hd.MaHD;
                XtraMessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CapNhatTongTienHD(int id, decimal tt, ref decimal result)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();
            HOADONBANHANG hd = db.HOADONBANHANGs.Single(p => p.MaHD == id);
            hd.TongTien += tt;

            try
            {
                db.SubmitChanges();
                result = hd.TongTien.Value;
                XtraMessageBox.Show("Thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
