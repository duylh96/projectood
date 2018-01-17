namespace ProjectDDS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_LapHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TuVanLapTop = new DevExpress.XtraBars.BarButtonItem();
            this.btn_TiepNhanBaoHanh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.btn_TuVanPC = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btn_LapHoaDon,
            this.btn_TuVanLapTop,
            this.btn_TiepNhanBaoHanh,
            this.barButtonItem1,
            this.btn_TuVanPC});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 6;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(955, 147);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // btn_LapHoaDon
            // 
            this.btn_LapHoaDon.Caption = "Lập hóa đơn";
            this.btn_LapHoaDon.Id = 1;
            this.btn_LapHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_LapHoaDon.ImageOptions.Image")));
            this.btn_LapHoaDon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_LapHoaDon.ImageOptions.LargeImage")));
            this.btn_LapHoaDon.Name = "btn_LapHoaDon";
            this.btn_LapHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_LapHoaDon_ItemClick);
            // 
            // btn_TuVanLapTop
            // 
            this.btn_TuVanLapTop.Caption = "Tư vấn Laptop";
            this.btn_TuVanLapTop.Id = 2;
            this.btn_TuVanLapTop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TuVanTheoYeuCau.ImageOptions.Image")));
            this.btn_TuVanLapTop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TuVanTheoYeuCau.ImageOptions.LargeImage")));
            this.btn_TuVanLapTop.Name = "btn_TuVanLapTop";
            this.btn_TuVanLapTop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TuVanLapTop_ItemClick);
            // 
            // btn_TiepNhanBaoHanh
            // 
            this.btn_TiepNhanBaoHanh.Caption = "Tiếp nhận bảo hành";
            this.btn_TiepNhanBaoHanh.Id = 3;
            this.btn_TiepNhanBaoHanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_TiepNhanBaoHanh.ImageOptions.Image")));
            this.btn_TiepNhanBaoHanh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_TiepNhanBaoHanh.ImageOptions.LargeImage")));
            this.btn_TiepNhanBaoHanh.Name = "btn_TiepNhanBaoHanh";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Hồ sơ bảo hành";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_LapHoaDon);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_TuVanLapTop);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_TuVanPC);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Bán hàng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_TiepNhanBaoHanh);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý bảo hành";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 561);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(955, 23);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // btn_TuVanPC
            // 
            this.btn_TuVanPC.Caption = "Tư vấn PC";
            this.btn_TuVanPC.Id = 5;
            this.btn_TuVanPC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btn_TuVanPC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btn_TuVanPC.Name = "btn_TuVanPC";
            this.btn_TuVanPC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_TuVanPC_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 584);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Quản lý cửa hàng DDS";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btn_LapHoaDon;
        private DevExpress.XtraBars.BarButtonItem btn_TuVanLapTop;
        private DevExpress.XtraBars.BarButtonItem btn_TiepNhanBaoHanh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.BarButtonItem btn_TuVanPC;
    }
}

