using Gljivar.Models;
using Microsoft.EntityFrameworkCore;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IGljivaService
    {
        Task<List<Gljiva>> getGljive();
        Task<List<GljivaUmjestu>> getGljiveUMjestu(int id);
        Task<Gljiva> getGljivaDetails(int id);
    }
    public class GljivaService : RepositoryBase<Gljiva>, IRepository<Gljiva>, IGljivaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public GljivaService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Gljiva> getGljivaDetails(int id)
        {
            return await DbContext.Gljiva.Where(x => x.IdGljive == id).FirstAsync();
        }

        public async Task<List<Gljiva>> getGljive()
        {
            //Gljiva u mjestu
            return await DbContext.Gljiva.Include(x => x.GljivaUmjestu).ToListAsync();

        }

        public async Task<List<GljivaUmjestu>> getGljiveUMjestu(int id)
        {
            return await DbContext.GljivaUmjestu.Include(x => x.IdGljivaNavigation).Include(x => x.IdGljiva1).Where(x => x.IdGljiva == id).ToListAsync();
        }
    }
}
