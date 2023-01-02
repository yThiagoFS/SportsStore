﻿using Microsoft.EntityFrameworkCore;
using SportsStore.Context;
using SportsStore.Repository;

namespace SportsStore.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreContext _context;
        public OrderRepository(StoreContext context)
        {
            _context = context;
        }
        public IQueryable<Order> Orders => _context.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);

        public void SaveOrder(Order order)
        {
            _context.AttachRange(order.Lines.Select(l => l.Product));
            if(order.OrderID == 0)
            {
                _context.Orders.Add(order);
            }
            _context.SaveChanges();
        }
    }
}
