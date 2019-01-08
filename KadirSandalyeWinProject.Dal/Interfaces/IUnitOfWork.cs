﻿using System;

namespace KadirSandalyeWinProject.Dal.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        IRepository<T> Rep { get; }
        bool Save();
    }
}
