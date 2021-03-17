using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BWACheckLogNoAuth.Server.Data.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();

        void Complete();
    }
}
