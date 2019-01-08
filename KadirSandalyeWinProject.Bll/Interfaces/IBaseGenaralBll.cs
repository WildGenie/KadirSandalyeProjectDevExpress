

using KadirSandalyeWinProject.Model.Entities.Base;

namespace KadirSandalyeWinProject.Bll.Interfaces
{
    public interface IBaseGenaralBll
    {
        bool Insert(BaseEntity entity);
        bool Update(BaseEntity oldEntity, BaseEntity currentEntity);
        string YeniKodVer();
    }
}
