using System.Collections.Generic;
using System.Threading.Tasks;
using Cozma_Miruna_Lab12.Models;

namespace Cozma_Miruna_Lab12.Data
{
    
    
        public interface IRestService
        {
            Task<List<ShopList>> RefreshDataAsync();
            Task SaveShopListAsync(ShopList item, bool isNewItem);
            Task DeleteShopListAsync(int id);
        }
    
}
