using KadirSandalyeWinProject.Forms.BaseForms;
using KadirSandalyeWinProject.Bll.Genaral;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Show;
using KadirSandalyeWinProject.Model.Entities;
using KadirSandalyeWinProject.Functions;

namespace KadirSandalyeWinProject.Forms.ProductsForms
{
    public partial class ProductListForm : BaseListForm
    {
        public ProductListForm()
        {
            InitializeComponent();
            Bll = new ProductBll();
        }

        protected override void DegiskenleriDoldur()
        {
            Tablo = tablo;
            kartTuru = KartTuru.Product;
            FormShow = new ShowEditForms<ProductEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void Listele()
        {
            Tablo.GridControl.DataSource = ((ProductBll)Bll).List(FilterFunctions.filter<Product>(AktifKartlariGöster));
        }
    }
}