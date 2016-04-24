using System.Collections.Generic;
using Domain.Orders;

namespace DAL.Interfaces.Orders
{
    public interface IOrderRepository : IEFRepository<Order>
    {
        List<Order> GetAllUserOrders(int userId);
        Order GetUserOrder(int orderId, int userId);
    }
}