using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Google.Apis.Customsearch.v1;
using Google.Apis.Customsearch.v1.Data;
using Google.Apis.Services;
using ProjectDDS.GUI;

namespace ProjectDDS
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btn_LapHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = kiemtraform(typeof(GUI.ManHinhLapHoaDon.LapHoaDon));
            if (form == null)
            {
                form = new GUI.ManHinhLapHoaDon.LapHoaDon();
                form.MdiParent = this;
                form.Show();
            }
            else
                form.Activate();
        }
    }
}
