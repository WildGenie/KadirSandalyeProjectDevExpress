using DevExpress.XtraEditors;
using KadirSandalyeWinProject.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace KadirSandalyeWinProject.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyMemoEdit : MemoEdit, IStatusBarAciklama
    {        
        public MyMemoEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 500;
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; } = "Açıklama Giriniz.";

    }
}
