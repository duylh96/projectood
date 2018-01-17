using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ProjectDDS.DAO;
using ProjectDDS.BUS;

namespace ProjectDDS.GUI.ManHinhLapHoaDon
{
    public partial class LapHoaDon : DevExpress.XtraEditors.XtraForm
    {
        private List<String> listProducts = new List<string>();
        private int currentMaHD;
        private string selectedTenMH;

        public LapHoaDon()
        {
            InitializeComponent();
            this.DisableAll();

            //Init combobox data
            listProducts.Add("Laptop");
            listProducts.Add("CPU");
            listProducts.Add("RAM");
            listProducts.Add("VGA");
            listProducts.Add("MAINBOARD");
            listProducts.Add("HARD DISK");
            listProducts.Add("PSU");

            cbb_LoaiSanPham.Properties.DataSource = listProducts;
        }

        private void DisableAll()
        {
            cbb_LoaiSanPham.Enabled = false;
            checkEditSP.Enabled = false;
            checkEditTT.Enabled = false;
            btn_Add.Enabled = false;
            btn_Delete.Enabled = false;
            edt_SoLuong.Enabled = false;
            edt_SuaSoLuong.Enabled = false;
            btn_CapNhat.Enabled = false;

            gridControlChiTiet.DataSource = null;
            gridControlMatHang.DataSource = null;
        }

        private void EnableAll()
        {
            cbb_LoaiSanPham.Enabled = true;
            checkEditSP.Enabled = true;
            checkEditTT.Enabled = true;
            btn_Add.Enabled = true;
            btn_Delete.Enabled = true;
            edt_SoLuong.Enabled = true;
            edt_SuaSoLuong.Enabled = true;
            btn_CapNhat.Enabled = true;
        }

        private void cbb_LoaiSanPham_EditValueChanged(object sender, EventArgs e)
        {
            gridControlMatHang.DataSource = null;
            gridControlMatHang.RefreshDataSource();
            gridViewMatHang.Columns.Clear();
            //Filter table mat hang
            switch (cbb_LoaiSanPham.Text)
            {
                case "Laptop":
                    gridControlMatHang.DataSource = new QLCuaHangDDSDataContext().LAPTOPs;
                    gridControlMatHang.RefreshDataSource();
                    gridViewMatHang.Columns[0].Caption = "Tên laptop";
                    gridViewMatHang.Columns[1].Caption = "Hãng sản xuất";
                    gridViewMatHang.Columns[2].Caption = "Giá (VNĐ)";
                    gridViewMatHang.Columns[3].Visible = false;
                    gridViewMatHang.Columns[4].Visible = false;
                    gridViewMatHang.Columns[5].Visible = false;
                    gridViewMatHang.Columns[6].Visible = false;
                    gridViewMatHang.Columns[7].Visible = false;
                    gridViewMatHang.Columns[8].Visible = false;
                    break;

                case "CPU":
                    gridControlMatHang.DataSource = new QLCuaHangDDSDataContext().CPUs;
                    gridControlMatHang.RefreshDataSource();
                    gridViewMatHang.Columns[0].Caption = "Tên CPU";
                    gridViewMatHang.Columns[1].Caption = "Giá (VNĐ)";
                    gridViewMatHang.Columns[2].Caption = "Hãng sản xuất";
                    gridViewMatHang.Columns[3].Visible = false;
                    gridViewMatHang.Columns[4].Visible = false;
                    gridViewMatHang.Columns[5].Visible = false;
                    gridViewMatHang.Columns[6].Visible = false;
                    break;

                case "RAM":
                    gridControlMatHang.DataSource = new QLCuaHangDDSDataContext().RAMs;
                    gridControlMatHang.RefreshDataSource();
                    gridViewMatHang.Columns[0].Caption = "Tên RAM";
                    gridViewMatHang.Columns[1].Caption = "Giá (VNĐ)";
                    gridViewMatHang.Columns[2].Caption = "Hãng sản xuất";
                    gridViewMatHang.Columns[3].Visible = false;
                    gridViewMatHang.Columns[4].Visible = false;
                    gridViewMatHang.Columns[5].Caption = "Dung lượng (GB)";
                    gridViewMatHang.Columns[6].Visible = false;
                    gridViewMatHang.Columns[7].Visible = false;
                    gridViewMatHang.Columns[8].Visible = false;
                    break;

                case "VGA":
                    gridControlMatHang.DataSource = new QLCuaHangDDSDataContext().VGAs;
                    gridControlMatHang.RefreshDataSource();
                    gridViewMatHang.Columns[0].Caption = "Tên VGA";
                    gridViewMatHang.Columns[1].Caption = "Giá (VNĐ)";
                    gridViewMatHang.Columns[2].Caption = "Hãng sản xuất";
                    gridViewMatHang.Columns[3].Visible = false;
                    gridViewMatHang.Columns[4].Visible = false;
                    break;

                case "MAINBOARD":
                    gridControlMatHang.DataSource = new QLCuaHangDDSDataContext().MAINBOARDs;
                    gridControlMatHang.RefreshDataSource();
                    gridViewMatHang.Columns[0].Caption = "Tên MAINBOARD";
                    gridViewMatHang.Columns[1].Caption = "Giá (VNĐ)";
                    gridViewMatHang.Columns[2].Visible = false;
                    gridViewMatHang.Columns[3].Visible = false;
                    gridViewMatHang.Columns[4].Visible = false;
                    gridViewMatHang.Columns[5].Visible = false;
                    gridViewMatHang.Columns[6].Visible = false;
                    gridViewMatHang.Columns[7].Visible = false;
                    gridViewMatHang.Columns[8].Visible = false;
                    gridViewMatHang.Columns[9].Visible = false;
                    break;

                case "HARD DISK":
                    gridControlMatHang.DataSource = new QLCuaHangDDSDataContext().HARDDISKs;
                    gridControlMatHang.RefreshDataSource();
                    gridViewMatHang.Columns[0].Caption = "Tên HARD DISK";
                    gridViewMatHang.Columns[1].Visible = false;
                    gridViewMatHang.Columns[2].Caption = "Giá (VNĐ)";
                    gridViewMatHang.Columns[3].Caption = "Hãng sản xuất";
                    gridViewMatHang.Columns[4].Visible = false;
                    gridViewMatHang.Columns[5].Caption = "Dung lượng (GB)";
                    gridViewMatHang.Columns[6].Visible = false;
                    gridViewMatHang.Columns[7].Visible = false;
                    gridViewMatHang.Columns[8].Visible = false;
                    gridViewMatHang.Columns[9].Visible = false;
                    gridViewMatHang.Columns[10].Visible = false;
                    gridViewMatHang.Columns[11].Visible = false;
                    break;

                case "PSU":
                    gridControlMatHang.DataSource = new QLCuaHangDDSDataContext().PSUs;
                    gridControlMatHang.RefreshDataSource();
                    gridViewMatHang.Columns[0].Caption = "Tên Nguồn";
                    gridViewMatHang.Columns[1].Caption = "Giá (VNĐ)";
                    gridViewMatHang.Columns[2].Caption = "Hãng sản xuất";
                    gridViewMatHang.Columns[3].Caption = "Điện năng (W)";
                    gridViewMatHang.Columns[4].Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void checkEditSP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditSP.Checked)
                edt_GiamGiaTriSP.Enabled = true;
            else
            {
                edt_GiamGiaTriSP.Enabled = false;
                edt_GiamGiaTriSP.Text = "0";
            }
        }

        private void checkEditTT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditTT.Checked)
                edt_GiamGiaTriTT.Enabled = true;
            else
            {
                edt_GiamGiaTriTT.Enabled = false;
                edt_GiamGiaTriTT.Text = "0";
            }
        }

        private void btn_LapHoaDon_Click(object sender, EventArgs e)
        {
            HOADONBANHANG hd = new HOADONBANHANG();
            hd.TenKH = edt_TenKH.Text.ToString();
            hd.NgayLap = DateTime.Now;
            hd.TongTien = 0;
            HoaDonBanHangBUS.ThemHoaDon(hd, ref this.currentMaHD);
            this.EnableAll();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            edt_TenKH.Text = "";
            this.DisableAll();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CHITIETHOADONBANHANG ct = new CHITIETHOADONBANHANG();
            ct.MaHD = this.currentMaHD;
            ct.TenMH = gridViewMatHang.GetFocusedRowCellValue("Ten").ToString();
            ct.GiamGiaTrenMatHang = 0;
            ct.GiamGiaTrenThanhTien = 0;
            ct.SoLuong = int.Parse(edt_SoLuong.Text.ToString());
            ct.DonGia = decimal.Parse(gridViewMatHang.GetFocusedRowCellValue("DonGia").ToString());
            ct.ThanhTien = ct.DonGia * ct.SoLuong;

            decimal result = 0;
            if (ChiTietHDBHBUS.ThemChiTietHD(ct, ref result))
            {
                edt_TongTien.Text = result.ToString();
                this.refreshTableChiTiet();
            }
        }

        private void refreshTableChiTiet()
        {
            this.gridControlChiTiet.DataSource = ChiTietHDBHDAO.loadAllChiTietById(this.currentMaHD);
            this.gridControlChiTiet.RefreshDataSource();
            gridViewChiTiet.Columns[0].Visible = false;
            gridViewChiTiet.Columns[1].Caption = "Tên mặt hàng";
            gridViewChiTiet.Columns[2].Caption = "Số lượng";
            gridViewChiTiet.Columns[3].Caption = "Đơn giá (VNĐ)";
            gridViewChiTiet.Columns[4].Caption = "Giảm giá trên mặt hàng";
            gridViewChiTiet.Columns[5].Caption = "Giảm giá trên thành tiền";
            gridViewChiTiet.Columns[6].Caption = "Thành tiền (VNĐ)";
            gridViewChiTiet.Columns[7].Visible = false;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                decimal result = 0;
                if (ChiTietHDBHBUS.XoaChiTietHD(this.currentMaHD, this.selectedTenMH, ref result))
                {
                    edt_TongTien.Text = result.ToString();
                    this.refreshTableChiTiet();
                }
            }
            catch (Exception) { }
        }

        private void gridViewChiTiet_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                this.selectedTenMH = gridViewChiTiet.GetFocusedRowCellValue("TenMH").ToString();
                edt_GiamGiaTriSP.Text = gridViewChiTiet.GetFocusedRowCellValue("GiamGiaTrenMatHang").ToString();
                edt_GiamGiaTriTT.Text = gridViewChiTiet.GetFocusedRowCellValue("GiamGiaTrenThanhTien").ToString();
                edt_SuaSoLuong.Text = gridViewChiTiet.GetFocusedRowCellValue("SoLuong").ToString();
            }
            catch (Exception) { }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {

            CHITIETHOADONBANHANG ct = new CHITIETHOADONBANHANG();
            try
            {
                ct.GiamGiaTrenMatHang = double.Parse(edt_GiamGiaTriSP.Text.ToString()) / 100;
                ct.GiamGiaTrenThanhTien = double.Parse(edt_GiamGiaTriTT.Text.ToString()) / 100;
                ct.SoLuong = int.Parse(edt_SuaSoLuong.Text.ToString());
            }
            catch (Exception) { return; }

            decimal result = 0;
            if (ChiTietHDBHBUS.CapNhatChiTietHD(this.currentMaHD, this.selectedTenMH, ct, ref result))
            {
                edt_TongTien.Text = result.ToString();
                this.refreshTableChiTiet();
            }
        }
    }
}