using System.Threading.Tasks;

namespace My.Model.DatabaseConnector
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
