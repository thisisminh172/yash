using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.ViewModels.Catalog.Orders;

namespace yash.Application.Catalog.Orders
{
    public interface IOrderService
    {
        Task<int> Create(OrderCreateRequest request);
    }
}
