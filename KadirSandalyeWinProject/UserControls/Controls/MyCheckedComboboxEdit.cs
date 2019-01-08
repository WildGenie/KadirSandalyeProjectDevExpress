using DevExpress.XtraEditors;
using System.Drawing;
using System.ComponentModel;
using KadirSandalyeWinProject.Interfaces;

namespace KadirSandalyeWinProject.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCheckedComboboxEdit:CheckedComboBoxEdit,IStatusBarKisaYol
    {
        public MyCheckedComboboxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;            
        }

        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarKisaYol { get; set; }
        public string StatusBarKisaYolAciklama { get; set; }
        public string StatusBarAciklama { get; set; }
    }
}
