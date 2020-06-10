using Gljivar.Models;
using Microsoft.EntityFrameworkCore;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IKomentarService
    {
        
        Task<List<Komentar>> getAllComments();
        
        Task addNewComment(Komentar komentar);

        Task<List<Komentar>> getAllCommentsForObjava(int idObjava);

    }
    public class KomentarService : RepositoryBase<Komentar>, IRepository<Komentar>, IKomentarService
    {
        private readonly IUnitOfWork _unitOfWork;

        public KomentarService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task addNewComment(Komentar komentar)
        {
            await DbContext.AddAsync<Komentar>(komentar);
            await _unitOfWork.Commit();
        }

        public async Task<List<Komentar>> getAllComments()
        {
            return await DbContext.Komentar.ToListAsync();
        }

        public async Task<List<Komentar>> getAllCommentsForObjava(int idObjava)
        {
            var c = await DbContext.Komentar.Include(o => o.IdObjavaNavigation).Where(o => o.IdObjavaNavigation.IdObjava == idObjava).ToListAsync();

            return c;
        }
    }
}
