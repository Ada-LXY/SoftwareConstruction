using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementSystem
{
    public class OrderDetail
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Subtotal => Price * Quantity;

        public override bool Equals(object obj)
        {
            return obj is OrderDetail detail &&
                   ProductName == detail.ProductName;
        }

        public override int GetHashCode() => ProductName.GetHashCode();

        public override string ToString() =>
            $"{ProductName} - Price: {Price:C} x {Quantity} = {Subtotal:C}";
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        private List<OrderDetail> details = new List<OrderDetail>();
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount => details.Sum(d => d.Subtotal);

        public IEnumerable<OrderDetail> Details => details.AsReadOnly();

        public void AddDetail(OrderDetail detail)
        {
            if (details.Contains(detail))
                throw new ArgumentException("Duplicate product in order details");
            details.Add(detail);
        }

        public bool RemoveDetail(OrderDetail detail) => details.Remove(detail);

        public override bool Equals(object obj) =>
            obj is Order order && OrderId == order.OrderId;

        public override int GetHashCode() => OrderId.GetHashCode();

        public override string ToString() =>
            $"Order {OrderId}\nCustomer: {Customer}\nDate: {OrderDate:d}\n" +
            $"Details:\n{string.Join("\n", details)}\nTotal: {TotalAmount:C}\n";
    }

    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new InvalidOperationException("Order already exists");
            orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
                throw new InvalidOperationException("Order not found");
            orders.Remove(order);
        }

        public void UpdateOrder(Order newOrder)
        {
            var index = orders.FindIndex(o => o.OrderId == newOrder.OrderId);
            if (index < 0)
                throw new InvalidOperationException("Order not found");
            orders[index] = newOrder;
        }

        public IEnumerable<Order> Query(Func<Order, bool> predicate) =>
            orders.Where(predicate).OrderBy(o => o.TotalAmount);

        public void Sort(Comparison<Order> comparison = null) =>
            orders.Sort(comparison ?? ((x, y) => x.OrderId.CompareTo(y.OrderId)));
    }

    class Program
    {
        static OrderService service = new OrderService();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1. Add Order\n2. Remove Order\n3. Update Order\n4. Query Orders\n5. Exit");
                switch (Console.ReadLine())
                {
                    case "1": AddOrder(); break;
                    case "2": RemoveOrder(); break;
                    case "3": UpdateOrder(); break;
                    case "4": QueryOrders(); break;
                    case "5": return;
                }
            }
        }

        static void AddOrder()
        {
            try
            {
                var order = new Order();
                Console.Write("Order ID: ");
                order.OrderId = int.Parse(Console.ReadLine());
                Console.Write("Customer: ");
                order.Customer = Console.ReadLine();

                do
                {
                    var detail = new OrderDetail();
                    Console.Write("Product Name: ");
                    detail.ProductName = Console.ReadLine();
                    Console.Write("Price: ");
                    detail.Price = decimal.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    detail.Quantity = int.Parse(Console.ReadLine());

                    try { order.AddDetail(detail); }
                    catch (ArgumentException e) { Console.WriteLine(e.Message); }

                } while (AskContinue("Add another product?"));

                service.AddOrder(order);
                Console.WriteLine("Order added!");
            }
            catch (Exception e) { Console.WriteLine($"Error: {e.Message}"); }
        }

        static void RemoveOrder()
        {
            try
            {
                Console.Write("Order ID to remove: ");
                service.RemoveOrder(int.Parse(Console.ReadLine()));
                Console.WriteLine("Order removed");
            }
            catch (Exception e) { Console.WriteLine($"Error: {e.Message}"); }
        }

        static void UpdateOrder()
        {
            try
            {
                Console.Write("Order ID to update: ");
                var id = int.Parse(Console.ReadLine());
                var oldOrder = service.Query(o => o.OrderId == id).FirstOrDefault() ??
                    throw new InvalidOperationException("Order not found");

                var newOrder = new Order { OrderId = id };
                Console.Write($"New Customer ({oldOrder.Customer}): ");
                newOrder.Customer = Console.ReadLine().IfEmpty(oldOrder.Customer);

                if (AskContinue("Keep existing products?"))
                {
                    foreach (var d in oldOrder.Details)
                        newOrder.AddDetail(d);
                }
                else
                {
                    do
                    {
                        var detail = new OrderDetail();
                        Console.Write("Product Name: ");
                        detail.ProductName = Console.ReadLine();
                        Console.Write("Price: ");
                        detail.Price = decimal.Parse(Console.ReadLine());
                        Console.Write("Quantity: ");
                        detail.Quantity = int.Parse(Console.ReadLine());

                        try { newOrder.AddDetail(detail); }
                        catch (ArgumentException e) { Console.WriteLine(e.Message); }

                    } while (AskContinue("Add another product?"));
                }

                service.UpdateOrder(newOrder);
                Console.WriteLine("Order updated!");
            }
            catch (Exception e) { Console.WriteLine($"Error: {e.Message}"); }
        }

        static void QueryOrders()
        {
            Console.WriteLine("Search by:\n1. Order ID\n2. Product\n3. Customer\n4. Amount Range");
            var choice = Console.ReadLine();
            IEnumerable<Order> result;

            // 使用传统switch语句替代switch表达式
            switch (choice)
            {
                case "1":
                    result = service.Query(o => o.OrderId == ReadInt("Order ID:"));
                    break;
                case "2":
                    result = service.Query(o => o.Details.Any(d => d.ProductName == ReadString("Product:")));
                    break;
                case "3":
                    result = service.Query(o => o.Customer.Contains(ReadString("Customer:")));
                    break;
                case "4":
                    result = service.Query(o => o.TotalAmount >= ReadDecimal("Min:") &&
                                              o.TotalAmount <= ReadDecimal("Max:"));
                    break;
                default:
                    result = Enumerable.Empty<Order>();
                    break;
            }

            Console.WriteLine(result.Any() ? string.Join("\n", result) : "No orders found");
        }

        static bool AskContinue(string prompt)
        {
            Console.Write($"{prompt} (y/n): ");
            return Console.ReadLine().ToLower() == "y";
        }

        static int ReadInt(string prompt) { Console.Write(prompt); return int.Parse(Console.ReadLine()); }
        static decimal ReadDecimal(string prompt) { Console.Write(prompt); return decimal.Parse(Console.ReadLine()); }
        static string ReadString(string prompt) { Console.Write(prompt); return Console.ReadLine(); }
    }

    public static class Extensions
    {
        public static string IfEmpty(this string input, string defaultValue) =>
            string.IsNullOrWhiteSpace(input) ? defaultValue : input;
    }
}