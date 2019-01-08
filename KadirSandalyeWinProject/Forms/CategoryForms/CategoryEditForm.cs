using KadirSandalyeWinProject.Bll.Genaral;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Forms.BaseForms;
using KadirSandalyeWinProject.Functions;
using KadirSandalyeWinProject.Model.Entities;

namespace KadirSandalyeWinProject.Forms.CategoryForms
{
    public partial class CategoryEditForm : BaseEditForm
    {
        public CategoryEditForm()
        {
            InitializeComponent();
            DataLayoutControl = myDataLayoutControl;
            Bll = new CategoryBll(myDataLayoutControl);
            kartTuru = KartTuru.Category;
            EventLoad();
        }

        protected internal override void Yukle()
        {
            OldEntity = islemTuru == IslemTuru.Insert ? new Category() : ((CategoryBll)Bll).Single(FilterFunctions.filter<Category>(Id));
            NesneyiKontrolleriBagla();

            if (islemTuru != IslemTuru.Insert) return;
            Id = islemTuru.IdOlustur(OldEntity);
            txtKod.Text = ((CategoryBll)Bll).YeniKodVer();
            txtCategoryName.Focus();
        }
        protected override void NesneyiKontrolleriBagla()
        {
            var entity = (Category)OldEntity;
            txtKod.Text = entity.Kod;
            txtCategoryName.Text = entity.CategoryName;            
            txtAciklama.Text = entity.Explanation;
            tglDurum.IsOn = entity.Durum;
        }
        protected override void GuncelNesneOlustur()
        {
            CurrentEntity = new Category
            {
                Id = Id,
                Kod = txtKod.Text,
                CategoryName = txtCategoryName.Text,                
                Explanation = txtAciklama.Text,
                Durum = tglDurum.IsOn
            };

            ButonEnableDurumu();
        }
    }
}