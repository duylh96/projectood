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
using DevExpress.XtraEditors.Controls;
using ProjectDDS.DAO;

namespace ProjectDDS.GUI.ManHinhTuVanPC
{
    public partial class TuVanPC : DevExpress.XtraEditors.XtraForm
    {
        public TuVanPC()
        {
            InitializeComponent();
        }

        private void btn_DeXuat_Click(object sender, EventArgs e)
        {
            decimal gia;
            try
            {
                gia = decimal.Parse(edt_Gia.Text.ToString());
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listBoxControl1.DataSource = TuVanPCDAO.GetDeXuatAMDByGia(gia, checkVGA.Checked, checkSSD.Checked);
            listBoxControl1.Refresh();

            listBoxControl2.DataSource = TuVanPCDAO.GetDeXuatIntelByGia(gia, checkVGA.Checked, checkSSD.Checked);
            listBoxControl2.Refresh();

            listBoxControl3.DataSource = TuVanPCDAO.GetDeXuatIntelByGia(gia, checkVGA.Checked, checkSSD.Checked);
            listBoxControl3.Refresh();
        }
    }
}