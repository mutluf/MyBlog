using MyBlog.Core.Entities;
using MyBlog.Data.Repositories.Abstaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.UnitOfWorks
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task<int> SaveAsync();
        int Save();

    }
}
