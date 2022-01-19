using System;
using System.Globalization;
using Exercicio_Proposto_Enum_e_Composicao.Entities;

namespace Exercicio_Proposto_Enum_e_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int itemQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemQuantity; i++)
            {
                Console.WriteLine("Enter #" + i + " item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product p = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem oi = new OrderItem(productQuantity, productPrice, p);
                order.AddItem(oi);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

        }
    }
}