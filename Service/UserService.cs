using Gljivar.Models;
using My.Model.DatabaseConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gljivar.Service
{
    public interface IUserService
    {
        
        bool checkUser(string name, string password);
    }

    public class UserService : RepositoryBase<Korisnik>, IRepository<Korisnik>, IUserService
    {
        // Init dependency injection
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IDbFactory dbFactory, IUnitOfWork unitOfWork) : base(dbFactory)
        {
            _unitOfWork = unitOfWork;
        }

        public bool checkUser(string name, string password)
        {
            return DbContext.Korisnik.Any(u => u.KorisnickoIme.Equals(name) && u.Pass.Equals(password));
        }
    }
}
