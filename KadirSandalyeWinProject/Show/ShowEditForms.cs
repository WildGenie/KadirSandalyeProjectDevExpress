using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Forms.BaseForms;
using KadirSandalyeWinProject.Show.Interfaces;
using System;

namespace KadirSandalyeWinProject.Show
{
    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
    {
        public long ShowDialogEditForm(KartTuru kartTuru, long id)//,params object[] prm)
        {
            //Yetki Kontrolü
            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.islemTuru = id > 0 ? IslemTuru.Update : IslemTuru.Insert;
                frm.Id = id;
                frm.Yukle();
                frm.ShowDialog();
                return frm.RefreshYap ? frm.Id : 0;
            }
        }
    }
}
