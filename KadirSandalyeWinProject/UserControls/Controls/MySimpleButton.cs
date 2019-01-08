using DevExpress.XtraEditors;
using KadirSandalyeWinProject.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace KadirSandalyeWinProject.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySimpleButton : SimpleButton, IStatusBarAciklama
    {
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarAciklama { get; set; }
    }
}
