namespace KadirSandalyeWinProject.Forms.BaseForms
{
    partial class BaseEditForm
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
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnYeni = new DevExpress.XtraBars.BarButtonItem();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnGeriAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.btnDuzelt = new DevExpress.XtraBars.BarButtonItem();
            this.statusBarAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarKisaYol = new DevExpress.XtraBars.BarStaticItem();
            this.statusBarKisaYolAciklama = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnYeni,
            this.btnKaydet,
            this.btnGeriAl,
            this.btnSil,
            this.btnCikis,
            this.btnDuzelt,
            this.statusBarAciklama,
            this.statusBarKisaYol,
            this.statusBarKisaYolAciklama});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 10;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowCategoryInCaption = false;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(619, 102);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnYeni
            // 
            this.btnYeni.Caption = "Yeni";
            this.btnYeni.Id = 1;
            this.btnYeni.ImageOptions.Image = global::KadirSandalyeWinProject.Properties.Resources.addfile_16x161;
            this.btnYeni.ImageOptions.LargeImage = global::KadirSandalyeWinProject.Properties.Resources.addfile_16x16;
            this.btnYeni.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert));
            this.btnYeni.Name = "btnYeni";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 2;
            this.btnKaydet.ImageOptions.Image = global::KadirSandalyeWinProject.Properties.Resources.save_16x16;
            this.btnKaydet.ImageOptions.LargeImage = global::KadirSandalyeWinProject.Properties.Resources.save_16x16;
            this.btnKaydet.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.btnKaydet.Name = "btnKaydet";
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Caption = "Geri Al";
            this.btnGeriAl.Id = 3;
            this.btnGeriAl.ImageOptions.Image = global::KadirSandalyeWinProject.Properties.Resources.reset_16x16;
            this.btnGeriAl.ImageOptions.LargeImage = global::KadirSandalyeWinProject.Properties.Resources.reset_16x16;
            this.btnGeriAl.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnGeriAl.Name = "btnGeriAl";
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 4;
            this.btnSil.ImageOptions.Image = global::KadirSandalyeWinProject.Properties.Resources.deletelist2_16x16;
            this.btnSil.ImageOptions.LargeImage = global::KadirSandalyeWinProject.Properties.Resources.deletelist2_16x16;
            this.btnSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnSil.Name = "btnSil";
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 5;
            this.btnCikis.ImageOptions.Image = global::KadirSandalyeWinProject.Properties.Resources.close_16x16;
            this.btnCikis.ImageOptions.LargeImage = global::KadirSandalyeWinProject.Properties.Resources.close_16x16;
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ShortcutKeyDisplayString = "Esc";
            // 
            // btnDuzelt
            // 
            this.btnDuzelt.Caption = "Düzelt";
            this.btnDuzelt.Id = 6;
            this.btnDuzelt.Name = "btnDuzelt";
            // 
            // statusBarAciklama
            // 
            this.statusBarAciklama.Id = 7;
            this.statusBarAciklama.ImageOptions.Image = global::KadirSandalyeWinProject.Properties.Resources.suggestion_16x16;
            this.statusBarAciklama.ImageOptions.LargeImage = global::KadirSandalyeWinProject.Properties.Resources.suggestion_16x16;
            this.statusBarAciklama.ItemAppearance.Normal.ForeColor = System.Drawing.Color.DarkBlue;
            this.statusBarAciklama.ItemAppearance.Normal.Options.UseForeColor = true;
            this.statusBarAciklama.Name = "statusBarAciklama";
            // 
            // statusBarKisaYol
            // 
            this.statusBarKisaYol.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusBarKisaYol.Id = 8;
            this.statusBarKisaYol.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.statusBarKisaYol.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green;
            this.statusBarKisaYol.ItemAppearance.Normal.Options.UseFont = true;
            this.statusBarKisaYol.ItemAppearance.Normal.Options.UseForeColor = true;
            this.statusBarKisaYol.Name = "statusBarKisaYol";
            // 
            // statusBarKisaYolAciklama
            // 
            this.statusBarKisaYolAciklama.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.statusBarKisaYolAciklama.Id = 9;
            this.statusBarKisaYolAciklama.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green;
            this.statusBarKisaYolAciklama.ItemAppearance.Normal.Options.UseForeColor = true;
            this.statusBarKisaYolAciklama.Name = "statusBarKisaYolAciklama";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYeni);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGeriAl);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCikis);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.statusBarAciklama);
            this.ribbonStatusBar1.ItemLinks.Add(this.statusBarKisaYol);
            this.ribbonStatusBar1.ItemLinks.Add(this.statusBarKisaYolAciklama);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 420);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(619, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // BaseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 451);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.MinimizeBox = false;
            this.Name = "BaseEditForm";
            this.Ribbon = this.ribbonControl;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar1;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnYeni;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraBars.BarButtonItem btnGeriAl;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private DevExpress.XtraBars.BarButtonItem btnDuzelt;
        private DevExpress.XtraBars.BarStaticItem statusBarAciklama;
        private DevExpress.XtraBars.BarStaticItem statusBarKisaYol;
        private DevExpress.XtraBars.BarStaticItem statusBarKisaYolAciklama;
        protected DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        
    }
}