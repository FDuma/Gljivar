using Gljivar.Models;
using Microsoft.EntityFrameworkCore;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IObjavaService
    {

        Task<Objava> getObjava(int id);


        Task<List<Objava>> getObjavas();

        Task addComment(int id, string comment, int userId = 0);


        Task<List<Korisnik>> getCommenters(int objavaId);
    }
    public class ObjavaService : RepositoryBase<Objava>, IRepository<Objava>, IObjavaService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ObjavaService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Objava> getObjava(int id)
        {
            return await DbContext.Objava.Include(x => x.IdGljivarDrustvoNavigation).Include(x => x.Komentar).Where(p => p.IdObjava == id).FirstAsync();
        }

        public async Task<List<Korisnik>> getCommenters(int objavaId)
        {
            return await DbContext.Korisnik.Include(x => x.Komentar).Where(k => k.Komentar.Any(kk => kk.IdObjava == objavaId)).ToListAsync();
        }

        public async Task<List<Objava>> getObjavas()
        {
            return await DbContext.Objava.ToListAsync();
        }

        public async Task addComment(int id, string komentar, int userId)
        {
            var koris = await DbContext.Korisnik.Where(k => k.IdKorisnik == userId).FirstAsync();

            Komentar noviKom = new Komentar()
            {
                Komentar1 = komentar,
                IdKorisnik = userId,
                IdObjava = id,
                Datum = DateTime.Now,
                IdKorisnikNavigation = koris
            }; ;
            //napravi novi komentar


            //spremi novi komentar
            await DbContext.Komentar.AddAsync(noviKom);


            //spremi sve u bazu
            await _unitOfWork.Commit();
        }
    }
}
