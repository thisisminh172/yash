using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.ProductTypes;

namespace yash.Application.Catalog.ProductTypes
{
    public interface IProductTypeService
    {
        Task<List<ProductType>> GetAll();
        Task<ProductType> GetById(int productTypeId);
        Task<int> Create(ProductTypeCreateRequest request);
        Task<int> Update(ProductTypeUpdateRequest request);
        Task<int> Delete(int productTypeId);
    }
}
