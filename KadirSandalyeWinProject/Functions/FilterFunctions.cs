using KadirSandalyeWinProject.Model.Entities.Base;
using System;
using System.Linq.Expressions;

namespace KadirSandalyeWinProject.Functions
{
    public class FilterFunctions
    {
        public static Expression<Func<T,bool>> filter<T>(bool aktifKartlariGöster) where T : BaseEntityDurum
        {
            return x => x.Durum == aktifKartlariGöster;
        }

        public static Expression<Func<T,bool>> filter<T>(long id) where T:BaseEntityDurum
        {
            return x => x.Id == id;
        }
    }
}
