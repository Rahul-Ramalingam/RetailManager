using RetailManagerDesktopUI.Models;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> AuthenticateAsync(string username, string password);

        Task GetLoggedInUserInfo(string token);
    }
}