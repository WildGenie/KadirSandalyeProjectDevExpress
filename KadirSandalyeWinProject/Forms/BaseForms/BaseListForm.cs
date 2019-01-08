using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Native;
using KadirSandalyeWinProject.Bll.Interfaces;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Functions;
using KadirSandalyeWinProject.Model.Entities.Base;
using KadirSandalyeWinProject.Show.Interfaces;

namespace KadirSandalyeWinProject.Forms.BaseForms
{
    public partial class BaseListForm : RibbonForm
    {
        protected IBaseFormShow FormShow;
        protected KartTuru kartTuru;
        protected GridView Tablo;
        protected bool AktifKartlariGöster = true;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;
        protected internal long? SeciliGelecekId;
        protected internal bool AktifPasifButonGoster = false;
        protected BarItem[] ShowItems;
        protected BarItem[] HideItems;
        public BaseListForm()
        {
            InitializeComponent();
        }

        private void EventLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Table Events
            Tablo.DoubleClick += Tablo_DoubleClick;
            Tablo.KeyDown += Tablo_KeyDown;
            Tablo.MouseUp += Tablo_MouseUp;

            //Form Events
            Shown += BaseListForm_Shown;
        }

        private void Tablo_MouseUp(object sender, MouseEventArgs e)
        {
            e.SagMenuGoster(sagMenu);
        }

        private void BaseListForm_Shown(object sender, EventArgs e)
        {
            Tablo.Focus();
            ButtonGizleGoster();
            //SutunGizleGoster();

            if (IsMdiChild || SeciliGelecekId == null) return;
            Tablo.RowFocus("Id", SeciliGelecekId);
        }

        private void ButtonGizleGoster()
        {
            btnSec.Visibility = AktifPasifButonGoster ? BarItemVisibility.Never : IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnter.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            barEnterAciklama.Visibility = IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;
            btnAktifPasifKartlar.Visibility = AktifPasifButonGoster ? BarItemVisibility.Always : !IsMdiChild ? BarItemVisibility.Never : BarItemVisibility.Always;

            ShowItems?.ForEach(x => x.Visibility = BarItemVisibility.Always);
            HideItems?.ForEach(x => x.Visibility = BarItemVisibility.Never);
        }

        protected internal void Yükle()
        {
            DegiskenleriDoldur();
            EventLoad();
            Tablo.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Tablo.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            Listele();
            Cursor.Current = DefaultCursor;

            //Güncellenecek
        }
        protected virtual void DegiskenleriDoldur() { }
        private void EntityDelete()
        {
            var entity = Tablo.GetRow<BaseEntity>();
            if (entity == null) return;
            if (!((IBaseCommonBll)Bll).Delete(entity)) return;

            Tablo.DeleteSelectedRows();
            Tablo.RowFocus(Tablo.FocusedRowHandle);
        }

        private void SelectEntity()
        {
            if (MultiSelect)
            {
                //Güncellenecek
            }
            else
                SelectedEntity = Tablo.GetRow<BaseEntity>();
            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void Listele() { }
        
        private void Yazdir()
        {
            throw new NotImplementedException();
        }
        private void FormCaptionAyarla()
        {
            if (btnAktifPasifKartlar == null)
            {
                Listele();
                return;
            }

            if (AktifKartlariGöster)
            {
                btnAktifPasifKartlar.Caption = "Pasif Kartlar";
                Tablo.ViewCaption = Text;
            }
            else
            {
                btnAktifPasifKartlar.Caption = "Aktif Kartlar";
                Tablo.ViewCaption = Text + " - Pasif Kartlar";
            }
            Listele();
        }
        private void IslemTuruSec()
        {
            if (!IsMdiChild)
            {
                //Güncellecek
                SelectEntity();
            }
            else
                btnDuzelt.PerformClick();
        }

        private void BagliKartAc()
        {
            throw new NotImplementedException();
        }
        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.Item == btnGonder)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandartExelDosyasi) 
            Tablo.TabloDısariAktar(DosyaTuru.ExelStandart, e.Item.Caption, Text);

            else if (e.Item == btnFormatliExelDosyasi)
            Tablo.TabloDısariAktar(DosyaTuru.ExelFormatli, e.Item.Caption, Text);

            else if (e.Item == btnFormatsizExelDosyasi) 
            Tablo.TabloDısariAktar(DosyaTuru.ExelFormatsiz, e.Item.Caption);

            else if (e.Item == btnWordDosyasi) 
            Tablo.TabloDısariAktar(DosyaTuru.WordDosyasi, e.Item.Caption);

            else if (e.Item == btnPdfDosyasi) 
            Tablo.TabloDısariAktar(DosyaTuru.PdfDosyasi, e.Item.Caption);

            else if (e.Item == btnTextDosyasi) 
            Tablo.TabloDısariAktar(DosyaTuru.TxtDosyasi, e.Item.Caption);
            else if (e.Item == btnYeni)
            {
                //Yetki Kontrolü
                ShowEditForm(-1);
            }
            else if (e.Item == btnDuzelt)
                ShowEditForm(Tablo.GetRowId());            
            else if (e.Item == btnSil)
            {
                //Yetki Kontrolü
                EntityDelete();
            }
            else if (e.Item == btnSec)
                SelectEntity();
            else if (e.Item == btnYenile)
                Listele();
            else if (e.Item == btnKolonlar)
            {
                if (Tablo.CustomizationForm == null)
                    Tablo.ShowCustomization();
                else
                    Tablo.HideCustomization();
            }
            else if (e.Item == btnBagliKartlar) { }
            //BagliKartAc();
            else if (e.Item == btnYazdir)
            Yazdir();
            else if (e.Item == btnCikis)
                Close();
            else if (e.Item == btnAktifPasifKartlar)
            {
                AktifKartlariGöster = !AktifKartlariGöster;
                FormCaptionAyarla();
            }

            Cursor.Current = DefaultCursor;
        }

        private void Tablo_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            IslemTuruSec();
            Cursor.Current = DefaultCursor;
        }
        

        private void Tablo_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    IslemTuruSec();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(kartTuru, id);
            ShowEditFormDefault(result);
        }

        protected void ShowEditFormDefault(long id)
        {
            if (id <= 0) return;
            AktifKartlariGöster = true;
            FormCaptionAyarla();
            Tablo.RowFocus("Id", id);
        }
    }

}
