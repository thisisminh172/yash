using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using yash.Data.Entities;
using yash.ViewModels.Catalog.Orders;

namespace yash.Application.Catalog.Orders
{
    public interface IOrderService
    {
        Task<int> Create(OrderCreateRequest request);
        Task<List<Order>> GetAll();
        Task<int> UpdateOrder(Order request);
        Task<List<OrderDetailAdminViewModel>> GetAllOrderDetail(int orderId);

        Task<List<OrderAdminViewModel>> GetAllOrderData();
    }
}
