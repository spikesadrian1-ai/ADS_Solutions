using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    internal interface IEasementRepository
    {        
        Task<object> GetAllEasements();
        Task<object> GetEasementByID(int id);
        Task<object> GetEasementByID();
    }
}