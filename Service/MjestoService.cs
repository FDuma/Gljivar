using Gljivar.Models;
using Microsoft.EntityFrameworkCore;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IMjestoService
    {

        Task<List<Mjesto>> getMjestos();

    }
    public class MjestoService : RepositoryBase<Mjesto>, IRepository<Mjesto>, IMjestoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MjestoService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Mjesto>> getMjestos()
        {
            return await DbContext.Mjesto.ToListAsync();
        }
    }
}
