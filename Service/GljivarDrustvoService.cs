using Gljivar.Models;
using Microsoft.EntityFrameworkCore;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IGljivarDrustvoService
    {
        Task<List<GljivarDrustvo>> getGljivarDrustvo();
        Task<GljivarDrustvo> getGljivarDrustvoDetails(int id);
    }
    public class GljivarDrustvoService : RepositoryBase<GljivarDrustvo>, IRepository<GljivarDrustvo>, IGljivarDrustvoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GljivarDrustvoService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<GljivarDrustvo>> getGljivarDrustvo()
        {
            return await DbContext.GljivarDrustvo.Include(x => x.IdMjestoNavigation).ToListAsync();
        }

        public async Task<GljivarDrustvo> getGljivarDrustvoDetails(int id)
        {
            return await DbContext.GljivarDrustvo.Include(x => x.IdMjestoNavigation).Where(x => x.IdGljivarDrustvo == id).FirstAsync();
        }
    }
}
