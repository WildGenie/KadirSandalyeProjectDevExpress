using KadirSandalyeWinProject.Bll.Base;
using KadirSandalyeWinProject.Bll.Interfaces;
using KadirSandalyeWinProject.Common.Enums;
using KadirSandalyeWinProject.Data.Context;
using KadirSandalyeWinProject.Model.Dto;
using KadirSandalyeWinProject.Model.Entities;
using KadirSandalyeWinProject.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace KadirSandalyeWinProject.Bll.Genaral
{
    public class ProductBll:BaseBll<Product, ProductContext>, IBaseGenaralBll,IBaseCommonBll
    {
        public ProductBll() { }

        public ProductBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<Product, bool>> filter)
        {
            return BaseSingle(filter, x => new ProductS
            {
                Id = x.Id,
                Kod = x.Kod,
                ProductName=x.ProductName,
                CategoryId=x.CategoryId,
                CategoryName=x.Category.CategoryName,
                Price=x.Price,
                Explanation=x.Explanation,
                Durum = x.Durum
            });
        }

        public IEnumerable<BaseEntity> List(Expression<Func<Product, bool>> filter)
        {
            return BaseList(filter, x => new ProductL
            {
                Id = x.Id,
                Kod = x.Kod,
                ProductName=x.ProductName,
                CategoryName=x.Category.CategoryName,
                Price=x.Price,
                Explanation=x.Explanation
            }).OrderBy(x => x.Kod).ToList();
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
            return BaseDelete(entity, KartTuru.Product);
        }
        public string YeniKodVer()
        {
            return BaseYeniKodVer(KartTuru.Product, x => x.Kod);
        }

    }
}
