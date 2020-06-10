using Gljivar.Models;
using Microsoft.EntityFrameworkCore;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IBiljeskaService
    {
        Task<List<Biljeska>> getBiljeske();

        Task<List<Biljeska>> getBiljeskeAutora(int userId);

        Task<Biljeska> getBiljeskaDetails(int id);
    }
    public class BiljeskaService : RepositoryBase<Biljeska>, IRepository<Biljeska>, IBiljeskaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BiljeskaService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Biljeska> getBiljeskaDetails(int id)
        {
            return await DbContext.Biljeska.Include(x => x.IdKorisnikaNavigation).Where(x => x.IdBiljeski == id).FirstAsync();
        }

        public async Task<List<Biljeska>> getBiljeske()
        {
            return await DbContext.Biljeska.ToListAsync();
        }

        public async Task<List<Biljeska>> getBiljeskeAutora(int userId)
        {
            return await DbContext.Biljeska.Where(b => b.IdKorisnika == userId).ToListAsync();
        }
    }
}
