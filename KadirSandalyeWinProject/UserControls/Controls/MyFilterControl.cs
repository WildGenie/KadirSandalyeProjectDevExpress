using DevExpress.XtraEditors;
using KadirSandalyeWinProject.Interfaces;
using System.ComponentModel;

namespace KadirSandalyeWinProject.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyFilterControl : FilterControl, IStatusBarAciklama
    {
        public MyFilterControl()
        {
            ShowGroupCommandsIcon = true;
        }

        public string StatusBarAciklama { get; set; } = "Filtre Metni Giriniz.";
    }
}
