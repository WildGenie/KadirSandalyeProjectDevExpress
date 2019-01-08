using DevExpress.XtraEditors;
using KadirSandalyeWinProject.Interfaces;
using System.ComponentModel;
using System.Drawing;

namespace KadirSandalyeWinProject.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit : TextEdit,IStatusBarAciklama
    {
        
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarAciklama { get; set; }
    }
}
