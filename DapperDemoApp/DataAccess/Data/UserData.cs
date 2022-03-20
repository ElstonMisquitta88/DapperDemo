using DataAccess.DbAccess;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<UserModel>> GetUsers()
        {
            return _db.LoadData<UserModel, dynamic>("Proc_GetAll", new { });
        }

    }
}
