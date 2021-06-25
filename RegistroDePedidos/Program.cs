using System;
using AppS9A123ExProp.Entities.Enums;
using AppS9A123ExProp.Entities;

namespace AppS9A123ExProp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("Nome: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de aniversário (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Entre com os dados do pedido: ");
            Console.Write("Status (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos itens para esse pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"#{i}Entre com os dados do item");
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(name, price);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem OrderItem = new OrderItem(quantity, price, product);

                order.AddItem(OrderItem);
            }

            Console.WriteLine();
            Console.WriteLine("Sumário do pedido");
            Console.WriteLine(order);


        }
    }
}
