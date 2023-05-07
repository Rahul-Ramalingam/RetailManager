using RetailManagerDesktopUI.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> AuthenticateAsync(string username, string password);

        Task GetLoggedInUserInfo(string token);

        HttpClient ApiClient { get; }
    }
}