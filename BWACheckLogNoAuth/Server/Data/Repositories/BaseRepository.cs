using BWACheckLogNoAuth.Server.Data.Context;

namespace BWACheckLogNoAuth.Server.Data.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
