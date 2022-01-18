using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_Proposto_Enum_e_Composicao.Entities;

namespace Exercicio_Proposto_Enum_e_Composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();



        public void AddItem (OrderItem item)
        {
            Item.Add(item);
        }

        public void RemoveItem (OrderItem item)
        {
            Item.Remove(item);
        }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, List<OrderItem> item)
        {
            Moment = moment;
            Status = status;
            Item = item;
        }
    }
}