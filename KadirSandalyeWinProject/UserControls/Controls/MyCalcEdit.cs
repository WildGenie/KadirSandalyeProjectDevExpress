using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils;
using System.ComponentModel;
using KadirSandalyeWinProject.Interfaces;

namespace KadirSandalyeWinProject.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit : CalcEdit, IStatusBarKisaYol
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "n2";
        }
        public override bool EnterMoveNextControl { get; set; }
        public string StatusBarKisaYol { get; set; } = "F4";
        public string StatusBarKisaYolAciklama { get; set; } = "Hesap Makinası";
        public string StatusBarAciklama { get; set; }
    }
}
