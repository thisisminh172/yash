using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.RingSizes;

namespace yash.Application.Catalog.RingSizes
{
    public interface IRingSizeService
    {
        Task<List<RingSize>> GetAll();
        Task<RingSize> GetById(int ringSizeId);
        Task<int> Create(RingSizeCreateRequest request);
        Task<int> Update(RingSizeUpdateRequest request);
        Task<int> Delete(int ringSizeId);
    }
}
