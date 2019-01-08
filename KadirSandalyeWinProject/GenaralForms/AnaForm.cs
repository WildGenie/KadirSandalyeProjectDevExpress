using DevExpress.XtraBars;
using KadirSandalyeWinProject.Forms.ProductsForms;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Show;
using KadirSandalyeWinProject.Forms.CategoryForms;
using DevExpress.XtraBars.Ribbon;

namespace KadirSandalyeWinProject.GenaralForms
{
    public partial class AnaForm :RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
            EventLoad();
        }
        private void EventLoad()
        {
            foreach (var item in ribbonControl.Items)
            {
                switch (item)
                {
                    case BarButtonItem btn:
                        btn.ItemClick += Butonlar_ItemClick;
                        break;
                }
            }
        }

        private void Butonlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item == btnProductCards)
                ShowListForms<ProductListForm>.ShowListForm(KartTuru.Product);
            if (e.Item == btnCategoryCards)
                ShowListForms<CategoryListForm>.ShowListForm(KartTuru.Category);
        }
    }
}