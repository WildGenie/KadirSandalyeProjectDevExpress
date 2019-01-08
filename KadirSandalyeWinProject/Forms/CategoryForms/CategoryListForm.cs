using KadirSandalyeWinProject.Bll.Genaral;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Forms.BaseForms;
using KadirSandalyeWinProject.Functions;
using KadirSandalyeWinProject.Model.Entities;
using KadirSandalyeWinProject.Show;

namespace KadirSandalyeWinProject.Forms.CategoryForms
{
    public partial class CategoryListForm : BaseListForm
    {
        public CategoryListForm()
        {
            InitializeComponent();
            Bll = new CategoryBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Category;
            FormShow = new ShowEditForms<CategoryEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((CategoryBll)Bll).List(FilterFunctions.filter<Category>(AktifKartlariGöster));
        }
    }
}