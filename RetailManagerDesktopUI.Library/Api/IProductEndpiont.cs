using RetailManagerDesktopUI.Library.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.Library.Api
{
    public interface IProductEndpiont
    {
        Task<List<ProductModel>> GetAllAsync();
    }
}