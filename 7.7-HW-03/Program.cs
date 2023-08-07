using System;

namespace _7_7_HW_03
{
    class Programm
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(age: 25, name: "Иван", lname: "Иванов");
            Product prod1 = new Product(vc: "ax032", name: "шуруповерт", price: 3500.25);
            Product prod2 = new Product(vc: "fr0065", name: "отвертка", price: 500);
            Courier couriertoday = new Courier(35, "Петр", "Петров", client1.contacts, client1.address);
            Order<HomeDelivery, string> order1 = new Order<HomeDelivery, string>(client1, "HD0001", new HomeDelivery(new DateTime(2023, 8, 15), client1.address, couriertoday));
            order1.AddItem(new Item(prod1, quantity: 1, prod1.price));
            order1 = order1 + (new Item(prod2, quantity: 5,prod2.price));
            order1.Show();
            Console.ReadKey();    
        }
    }
}