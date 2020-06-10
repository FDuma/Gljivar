using Gljivar.Models;
using Microsoft.EntityFrameworkCore;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IKorisnikService
    {
        Task<List<Korisnik>> getKorisnici();
        Task <Korisnik> getKorisnikDetails(int id);

        Task addKorisnik(Korisnik korisnik);

        Task deleteKorisnik(int id);

        Task updateKorisnik(int id, Korisnik korisnik);
    }
    public class KorisnikService : RepositoryBase<Korisnik>, IRepository<Korisnik>, IKorisnikService
    {
        private readonly IUnitOfWork _unitOfWork;

        public KorisnikService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }

        

        public async Task<List<Korisnik>> getKorisnici()
        {
            return await DbContext.Korisnik.Include(x => x.IdGljivarskoDrustvoNavigation).ToListAsync();
        }

        public async Task <Korisnik> getKorisnikDetails(int id)
        {
            return await DbContext.Korisnik.Include(x => x.IdGljivarskoDrustvoNavigation).Where(x => x.IdKorisnik == id).FirstAsync();
        }

        public async Task addKorisnik(Korisnik korisnik)
        {
            var korisNew = await DbContext.AddAsync<Korisnik>(korisnik);
            await _unitOfWork.Commit();
        }

        public async Task deleteKorisnik(int id)
        {
            if(DbContext.Korisnik.Any(k=>k.IdKorisnik == id))
            {
                if(DbContext.Objava.Any(k=>k.IdKorisnika == id))
                {
                    var objava = DbContext.Objava.Where(k => k.IdKorisnika == id);
                    DbContext.RemoveRange(objava);
                    foreach(var o in objava)
                    {
                        if (DbContext.Komentar.Any(k => k.IdObjava == o.IdObjava))
                        {
                            var remove = DbContext.Komentar.Where(k => k.IdObjava == o.IdObjava);
                            DbContext.RemoveRange(remove);
                        }
                    }

                }
                await _unitOfWork.Commit();
                
                if (DbContext.Komentar.Any(k => k.IdKorisnik == id))
                {
                    var komentar = DbContext.Komentar.Where(k => k.IdKorisnik == id);
                    DbContext.RemoveRange(komentar);
                }
                await _unitOfWork.Commit();
                
                if (DbContext.ProGljivar.Any(k => k.IdKorisnik == id))
                {
                    var remove = DbContext.ProGljivar.Where(k => k.IdKorisnik == id);
                    DbContext.RemoveRange(remove);
                }
                await _unitOfWork.Commit();
                
                if (DbContext.Biljeska.Any(k => k.IdKorisnika == id))
                {
                    var remove = DbContext.Biljeska.Where(k => k.IdKorisnika == id);
                    DbContext.RemoveRange(remove);
                }
                await _unitOfWork.Commit();

                var korisnik = DbContext.Korisnik.Where(k => k.IdKorisnik == id);
                DbContext.RemoveRange(korisnik);
                await _unitOfWork.Commit();


            }
        }

        public async Task updateKorisnik(int id, Korisnik korisnik)
        {
            var kor = await DbContext.Korisnik.FirstAsync(k => k.IdKorisnik == id);
            kor.Pass = korisnik.Pass;
            kor.IsAdmin = korisnik.IsAdmin;
            kor.KontaktBroj = korisnik.KontaktBroj;
            kor.Email = korisnik.Email;
            kor.IdMjesta = korisnik.IdMjesta;
            if (korisnik.IdGljivarskoDrustvo == -1)
            {
                kor.IdGljivarskoDrustvo = null;
            } else
            {
                kor.IdGljivarskoDrustvo = korisnik.IdGljivarskoDrustvo;
            }       
            kor.Ime = korisnik.Ime;
            kor.Prezime = korisnik.Prezime;
            kor.KorisnickoIme = korisnik.KorisnickoIme;

            DbContext.Update(kor);
            await _unitOfWork.Commit();
        }

        

    }
}
