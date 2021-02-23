using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Items;

namespace yash.Application.Catalog.Items
{
    public class ItemService : IItemService
    {
        public Task<int> Create(ItemCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int goldId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Item>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Item> GetById(int goldId)
        {
            throw new NotImplementedException();
        }
    }
}
