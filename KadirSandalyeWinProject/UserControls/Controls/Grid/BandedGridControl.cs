using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using System.Drawing;

namespace KadirSandalyeWinProject.UserControls.Controls.Grid
{
    [ToolboxItem(true)]
    public class MyBandedControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var bandedview = (MyBandedGridView)CreateView("MyBandedGridView");
            bandedview.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            bandedview.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            bandedview.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center;
            bandedview.BandPanelRowHeight = 40;
            bandedview.Appearance.ViewCaption.ForeColor = Color.Maroon;
            bandedview.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            bandedview.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;

            bandedview.Appearance.FooterPanel.ForeColor = Color.Maroon;
            bandedview.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);

            bandedview.OptionsMenu.EnableColumnMenu = false;
            bandedview.OptionsMenu.EnableFooterMenu = false;
            bandedview.OptionsMenu.EnableGroupPanelMenu = false;

            bandedview.OptionsNavigation.EnterMoveNextColumn = false;

            bandedview.OptionsPrint.AutoWidth = false;
            bandedview.OptionsPrint.PrintFooter = false;
            bandedview.OptionsPrint.PrintGroupFooter = false;

            bandedview.OptionsView.ShowViewCaption = true;
            bandedview.OptionsView.ShowAutoFilterRow = true;
            bandedview.OptionsView.ShowGroupPanel = false;
            bandedview.OptionsView.ColumnAutoWidth = false;
            bandedview.OptionsView.RowAutoHeight = true;
            bandedview.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;


            var columns = new[]
            {
                new BandedGridColumn
                {
                    Caption = "id",
                    FieldName = "Id",
                    OptionsColumn = {AllowEdit = false,ShowCaption = false}
                },
                new BandedGridColumn
                {
                    Caption = "Kod",
                    FieldName = "Kod",
                    OptionsColumn = {AllowEdit = false},
                    AppearanceCell={ TextOptions = { HAlignment = HorzAlignment.Center }, Options = {UseTextOptions=true } }
                }
            };

            bandedview.Columns.AddRange(columns);

            #region Kolon Oluşturma İkinci Kullanım
            //var idColumn = new BandedGridColumn
            //{
            //    Caption = "id",
            //    FieldName = "Id",
            //    OptionsColumn = { AllowEdit = false, ShowCaption = false }
            //};
            //idColumn.OptionsColumn.AllowEdit = false;
            //idColumn.OptionsColumn.ShowInCustomizationForm = false;
            //view.Columns.Add(idColumn);
            //var kodColumn = new BandedGridColumn
            //{
            //    Caption = "Kod",
            //    FieldName = "Kod"
            //};
            //kodColumn.OptionsColumn.AllowEdit = false;
            //kodColumn.Visible = true;
            //kodColumn.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            //kodColumn.AppearanceCell.Options.UseTextOptions = true;
            //view.Columns.Add(kodColumn); 
            #endregion

            return bandedview;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyBandedGridInfoRegistrator());
        }

        private class MyBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName => "MyBandedGridView";
            public override BaseView CreateView(GridControl grid) => new MyBandedGridView(grid);
        }
    }

    public class MyBandedGridView : BandedGridView//, IStatusBarKisaYol
    {
        #region Properties
        public string StatusBarKisaYol { get; set; }
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
        #endregion

        public MyBandedGridView() { }

        public MyBandedGridView(GridControl ownerGrid) : base(ownerGrid) { }


        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }
        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }

        private class MyGridColumnCollection : BandedGridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }
            protected override GridColumn CreateColumn()
            {
                var column = new MyBandedGridColumn();
                column.OptionsColumn.AllowEdit = false;
                return column;
            }
        }
    }

    public class MyBandedGridColumn : BandedGridColumn//, IStatusBarKisaYol
    {
        #region Properties
        public string StatusBarKisaYol { get; set; }
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
        #endregion
    }
}

