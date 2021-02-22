using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Diamonds;

namespace yash.Application.Catalog.Diamonds
{
    public interface IDiamondService
    {
        Task<List<Diamond>> GetAll();
        Task<Diamond> GetById(int diamondId);
        Task<int> Create(DiamondCreateRequest request);
        Task<int> Update(DiamondUpdateRequest request);
        Task<int> Delete(int diamondId);
    }
}
