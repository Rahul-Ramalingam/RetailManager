using RetailManagerDesktopUI.Models;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> AuthenticateAsync(string username, string password);
    }
}