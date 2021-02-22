using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Golds;

namespace yash.Application.Catalog.Golds
{
    public interface IGoldService
    {
        Task<List<Gold>> GetAll();
        Task<Gold> GetById(int goldId);
        Task<int> Create(GoldCreateRequest request);
        Task<int> Update(GoldUpdateRequest request);
        Task<int> Delete(int goldId);
    }
}
