using Gljivar.Models;
using My.Model.DatabaseConnector;

namespace My.Model.DatabaseConnector
{
    // Abstracting database entity so using can be made only dbContext object
    public class DbFactory : Disposable, IDbFactory
    {
        GljivarContext _dbContext;

        public DbFactory(GljivarContext context)
        {
            _dbContext = context;
        }
        
        public GljivarContext Init()
        {
            return _dbContext ?? (_dbContext = new GljivarContext());
        }

        protected override void DisposeCore()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}