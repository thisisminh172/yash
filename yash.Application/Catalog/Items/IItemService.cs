using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.ItemImages;
using yash.ViewModels.Catalog.Items;

namespace yash.Application.Catalog.Items
{
    public interface IItemService
    {
        Task<List<ItemViewModel>> GetAll();
        Task<List<ItemViewModel>> GetItemsByCategory(int categoryId);
        Task<ItemViewModel> GetById(int itemId);
        Task<List<ItemImageViewModel>> GetAllImages(int itemId);
        Task<int> Create(ItemCreateRequest request);
        //Task<int> Update(ItemUpdateReques request);
        Task<int> Delete(int itemId);
    }
}
