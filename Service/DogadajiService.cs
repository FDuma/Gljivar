using Gljivar.Models;
using Microsoft.EntityFrameworkCore;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IDogadajiService
    {
        Task<List<Dogadaj>> getDogadaji();
        Task<Dogadaj> getDogadajDetails(int id);
    }
    public class DogadajiService : RepositoryBase<Dogadaj>, IRepository<Dogadaj>, IDogadajiService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DogadajiService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Dogadaj> getDogadajDetails(int id)
        {
            return await DbContext.Dogadaj.Include(x=>x.IdGljivarDrustvoNavigation).Where(x => x.IdDogadaj == id).FirstAsync();
        }

        public async Task<List<Dogadaj>> getDogadaji()
        {
            //Gljiva u mjestu
            return await DbContext.Dogadaj.Include(x => x.IdMjestoNavigation).ToListAsync();

        }
    }
}