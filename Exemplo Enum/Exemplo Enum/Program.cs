using Exemplo_Enum.Entities;
using Exemplo_Enum.Entities.Enums;
using System;

namespace Exemplo_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Order order = new Order
            {
                id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
