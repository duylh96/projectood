using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace ProjectDDS.DAO
{
    public class ChiTietHDBHDAO
    {

        public static dynamic loadAllChiTietById(int id)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();
            var query = db.CHITIETHOADONBANHANGs.Where(p => p.MaHD == id);
            return query.ToList();
        }

        public static bool ThemChiTietHD(CHITIETHOADONBANHANG ct, ref decimal result)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();
            db.CHITIETHOADONBANHANGs.InsertOnSubmit(ct);

            try
            {
                db.SubmitChanges();
                HoaDonBanHangDAO.CapNhatTongTienHD(ct.MaHD, ct.ThanhTien.Value, ref result);
                XtraMessageBox.Show("Thêm thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool XoaChiTietHD(int id1, string id2, ref decimal result)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();
            var ct = db.CHITIETHOADONBANHANGs.Single(p => p.MaHD == id1 && p.TenMH == id2);
            db.CHITIETHOADONBANHANGs.DeleteOnSubmit(ct);

            try
            {
                db.SubmitChanges();
                HoaDonBanHangDAO.CapNhatTongTienHD(ct.MaHD, -ct.ThanhTien.Value, ref result);
                XtraMessageBox.Show("Xóa thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CapNhatChiTietHD(int id1, string id2, CHITIETHOADONBANHANG ctNew, ref decimal deltaTT)
        {
            QLCuaHangDDSDataContext db = new QLCuaHangDDSDataContext();
            var ct = db.CHITIETHOADONBANHANGs.Single(p => p.MaHD == id1 && p.TenMH == id2);
            ct.SoLuong = ctNew.SoLuong;

            decimal originTT = ct.ThanhTien.Value;

            ct.GiamGiaTrenMatHang = ctNew.GiamGiaTrenMatHang;
            ct.ThanhTien = ct.DonGia.Value * (1 - (decimal)ct.GiamGiaTrenMatHang.Value) * ct.SoLuong;

            ct.GiamGiaTrenThanhTien = ctNew.GiamGiaTrenThanhTien;
            ct.ThanhTien = ct.ThanhTien * (1 - (decimal)ct.GiamGiaTrenThanhTien.Value);

            try
            {
                db.SubmitChanges();
                decimal delta = ct.ThanhTien.Value - originTT;
                HoaDonBanHangDAO.CapNhatTongTienHD(ct.MaHD, delta, ref deltaTT);
                XtraMessageBox.Show("Cập nhật thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
