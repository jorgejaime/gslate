using Jorge.Gslate.Model.Repositories;
using System;

namespace Jorge.Gslate.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository ProjectRepository { get; set; }
        IUserRepository UserRepository { get; set; }
        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        int Commit();
    }
}
