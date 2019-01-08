using KadirSandalyeWinProject.Bll.Functions;
using KadirSandalyeWinProject.Bll.Interfaces;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Common.Functions;
using KadirSandalyeWinProject.Common.Message;
using KadirSandalyeWinProject.Dal.Interfaces;
using KadirSandalyeWinProject.Model.Attributes;
using KadirSandalyeWinProject.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KadirSandalyeWinProject.Bll.Base
{
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext : DbContext
    {
        private readonly Control _ctrl;
        private IUnitOfWork<T> _unitOfWork;

        protected BaseBll() { }

        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }
        private bool Validation(IslemTuru islemTuru, BaseEntity oldEntity, BaseEntity curruntEntity, Expression<Func<T, bool>> filter)
        {
            var errorControl = GetValidationErrorControl();
            if (errorControl == null) return true;
            _ctrl.Controls[errorControl].Focus();
            return false;
            string GetValidationErrorControl()
            {
                string MukerrerKod()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<Kod>())
                    {
                        if (property.Attribute == null) continue;
                        if ((islemTuru == IslemTuru.Insert || oldEntity.Kod == curruntEntity.Kod) && islemTuru == IslemTuru.Update) continue;
                        if (_unitOfWork.Rep.Count(filter) < 1) continue;

                        Messages.MukerrerKayitHataMesaji(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                string HataliGiris()
                {
                    foreach (var property in typeof(T).GetPropertyAttributesFromType<ZorunluAlan>())
                    {
                        if (property.Attribute == null) continue;
                        var value = property.Property.GetValue(curruntEntity);
                        if (property.Property.PropertyType == typeof(long))
                            if ((long)value == 0) value = null;
                        if (!string.IsNullOrEmpty(value?.ToString())) continue;
                        Messages.HataliVeriMEsaji(property.Attribute.Description);
                        return property.Attribute.ControlName;
                    }
                    return null;
                }
                return HataliGiris() ?? MukerrerKod();
            }
        }

        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.Select(filter, selector);
        }
        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (!Validation(IslemTuru.Insert, null, entity, filter)) return false;
            _unitOfWork.Rep.Insert(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity curruntEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (!Validation(IslemTuru.Update, oldEntity, curruntEntity, filter)) return false;
            var degisenAlanlar = oldEntity.DegisenAlanlarıGetir(curruntEntity);
            if (degisenAlanlar.Count == 0) return true;
            _unitOfWork.Rep.Update(curruntEntity.EntityConvert<T>(), degisenAlanlar);
            return _unitOfWork.Save();
        }

        protected bool BaseDelete(BaseEntity entity, KartTuru kartTuru, bool mesajVer = true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            if (mesajVer)
                if (Messages.SilMesaj(kartTuru.ToName()) != DialogResult.Yes) return false;
            _unitOfWork.Rep.Delete(entity.EntityConvert<T>());
            return _unitOfWork.Save();
        }
        protected string BaseYeniKodVer(KartTuru kartTuru, Expression<Func<T, string>> filter, Expression<Func<T, bool>> where = null)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _unitOfWork);
            return _unitOfWork.Rep.YeniKodVer(kartTuru, filter, where);
        }

        #region Dispose
        public void Dispose()
        {
            _ctrl?.Dispose();
            _unitOfWork?.Dispose();
        }
        #endregion

    }
}
