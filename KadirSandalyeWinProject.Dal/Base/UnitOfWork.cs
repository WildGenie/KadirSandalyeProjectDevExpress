using KadirSandalyeWinProject.Dal.Interfaces;
using System;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.Entity;
using KadirSandalyeWinProject.Common.Message;

namespace KadirSandalyeWinProject.Dal.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        #region Veriables
        private readonly DbContext _context;
        #endregion
        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }
        public IRepository<T> Rep => new Repository<T>(_context);

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var sqlEx = (SqlException)ex.InnerException?.InnerException;
                if (sqlEx == null)
                {
                    Messages.HataMesaji(ex.Message);
                    return false;
                }

                switch (sqlEx.Number)
                {
                    case 208:
                        Messages.HataMesaji("İşlem yapmak istediğiniz tablo veri tabanında bulunamadı.");
                        break;
                    case 547:
                        Messages.HataMesaji("Seçilen kartın işlem görmüş hareketleri var.Kart Silinemez.");
                        break;
                    case 2601:
                        break;
                    case 2627:
                        Messages.HataMesaji("Girmiş olduğunuz id daha önce kullanılmıştır.");
                        break;
                    case 4060:
                        Messages.HataMesaji("İşlem yapmak istediğiniz veri tabanı veri tabanı sunucusunda bulunamadı.");
                        break;
                    case 08456:
                        Messages.HataMesaji("Server'a bağlanılmak istenilen kullanıcı adı ve şifre hatalıdır.");
                        break;
                    default:
                        Messages.HataMesaji(sqlEx.Message);
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                Messages.HataMesaji(ex.Message);
                return false;
            }
            return true;
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                    _context.Dispose();

                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
