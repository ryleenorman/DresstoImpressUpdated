// Emily Surface 
using DresstoImpressAPI.Entities;
using System.Threading.Tasks;

namespace DresstoImpressAPI.Repositories
{
    public interface IUserOccupationService
    {
        Task<List<USERS>> GetUserOccupation(int UserID);
    }
}
