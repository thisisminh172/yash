using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Items;

namespace yash.Application.Catalog.Items
{
    public interface IItemService
    {
        Task<List<Item>> GetAll();
        Task<Item> GetById(int goldId);
        Task<int> Create(ItemCreateRequest request);
        //Task<int> Update(ItemUpdateReques request);
        Task<int> Delete(int goldId);
    }
}
