using DataAccess.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task<IEnumerable<UserModel>> GetUsers();
    }
}