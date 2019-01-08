using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Forms.CategoryForms;
using KadirSandalyeWinProject.Model.Entities;
using KadirSandalyeWinProject.Show;
using KadirSandalyeWinProject.UserControls.Controls;
using System;

namespace KadirSandalyeWinProject.Functions
{
    public class SelectFunctions : IDisposable
    {
        #region Veriables
        private MyButtonEdit _btnEdit;
        private MyButtonEdit _prmEdit;
        private KartTuru kartTuru; 
        #endregion

        public void Sec(MyButtonEdit btnEdit)
        {
            _btnEdit = btnEdit;
            SecimYap();
        }
        public void Sec(MyButtonEdit btnEdit, MyButtonEdit prmEdit)
        {
            _btnEdit = btnEdit;
            _prmEdit = prmEdit;
            SecimYap();
        }

        private void SecimYap()
        {
            switch (_btnEdit.Name)
            {
                case "txtKategoriAdi":
                    {
                        var entity = (Category)ShowListForms<CategoryListForm>.ShowDialogListForm(kartTuru, _btnEdit.Id);
                        if (entity != null)
                        {
                            _btnEdit.Id = entity.Id;
                            _btnEdit.EditValue = entity.CategoryName;
                        }
                    }
                    break;
            }            
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
