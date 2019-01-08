using KadirSandalyeWinProject.Bll.Base;
using KadirSandalyeWinProject.Bll.Interfaces;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Data.Context;
using KadirSandalyeWinProject.Model.Entities;
using KadirSandalyeWinProject.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace KadirSandalyeWinProject.Bll.Genaral
{
    public class CategoryBll: BaseBll<Category, ProductContext>, IBaseGenaralBll, IBaseCommonBll
    {
        public CategoryBll() { }
        public CategoryBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Category, bool>> filter)
        {
            return BaseSingle(filter, x => x);
        }

        public IEnumerable<BaseEntity> List(Expression<Func<Category, bool>> filter)
        {
            return BaseList(filter, x => x).OrderBy(x => x.Kod).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Kod == entity.Kod);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Kod == currentEntity.Kod);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, KartTuru.Category);
        }

        public string YeniKodVer()
        {
            return BaseYeniKodVer(KartTuru.Category, x => x.Kod);
        }
    }
}
