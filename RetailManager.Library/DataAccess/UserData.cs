using RetailManager.Library.Internal.DataAccess;
using RetailManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManager.Library.DataAccess
{
    public class UserData
    {
        public List<UserModel> GetUserById(string Id)
        {
            var sql = new SqlDataAccess();

            var p = new { Id = Id };

            return sql.LoadData<UserModel, dynamic>("dbo.spUserLookup", p, "RetailManagerData");
        }
    }
}
