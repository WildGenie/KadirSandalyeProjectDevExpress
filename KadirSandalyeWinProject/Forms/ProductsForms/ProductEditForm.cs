using DevExpress.XtraEditors;
using KadirSandalyeWinProject.Bll.Genaral;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Forms.BaseForms;
using KadirSandalyeWinProject.Functions;
using KadirSandalyeWinProject.Model.Dto;
using KadirSandalyeWinProject.Model.Entities;
using System;

namespace KadirSandalyeWinProject.Forms.ProductsForms
{
    public partial class ProductEditForm : BaseEditForm
    {
        public ProductEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new ProductBll(myDataLayoutControl);
            kartTuru = KartTuru.Product;
            EventLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = islemTuru == IslemTuru.Insert ? new ProductS() : ((ProductBll)Bll).Single(FilterFunctions.filter<Product>(Id));
            NesneyiKontrolleriBagla();

            if (islemTuru != IslemTuru.Insert) return;
            Id = islemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((ProductBll)Bll).YeniKodVer();
            txtUrunAdi.Focus();
        }
        protected override void NesneyiKontrolleriBagla()
        {
            var entity = (ProductS)OldEntity;
            txtKod.Text = entity.Kod;
            txtUrunAdi.Text = entity.ProductName;
            txtKategoriAdi.Id = entity.CategoryId;
            txtKategoriAdi.Text = entity.CategoryName;
            txtFiyat.Text = Convert.ToDecimal(entity.Price).ToString();
            txtAciklama.Text = entity.Explanation;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Product
            {
                Id = Id,
                Kod = txtKod.Text,
                ProductName = txtUrunAdi.Text,
                CategoryId = Convert.ToInt64(txtKategoriAdi.Id),
                Price = Convert.ToDecimal(txtFiyat.Text),
                Explanation = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnableDurumu();
        }
        protected override void SecimYap(object sender)
        {
            if (!(sender is ButtonEdit)) return;

            using (var sec = new SelectFunctions())
            {
                if (sender == txtKategoriAdi)
                    sec.Sec(txtKategoriAdi);                
            }
        }        
    }
}