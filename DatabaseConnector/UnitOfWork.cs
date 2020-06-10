using System.Threading.Tasks;
using Gljivar.Models;

namespace My.Model.DatabaseConnector
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private GljivarContext _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        private GljivarContext DbContext => _dbContext ?? (_dbContext = _dbFactory.Init());

        public async Task Commit()
        {
            await DbContext.SaveChangesAsync();
        }
    }
}
