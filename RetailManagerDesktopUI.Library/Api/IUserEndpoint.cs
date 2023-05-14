using RetailManagerDesktopUI.Library.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.Library.Api
{
    public interface IUserEndpoint
    {
        Task<List<ApplicationUserModel>> GetAllAsync();

        Task<Dictionary<string, string>> GetAllRolesAsync();

        Task AddUserToRoleAsync(string userId, string RoleName);

        Task RemoveUserFromRoleAsync(string userId, string RoleName);
    }
}