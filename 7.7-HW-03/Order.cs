using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_7_HW_03
{
    class Order<TDelivery, T> where TDelivery : Delivery
    {
        protected T orderId = default(T);
        protected int orderNum;
        protected DateTime orderDate;
        protected DateTime deliveryDate;
        private TDelivery delivery;
        List<Item> items;
        Client client;
        public Order(Client client, T id, TDelivery delivery)
        {
            orderId = id;
            this.delivery = delivery;
            orderNum++;
            this.client = client;
            orderDate = DateTime.Now;
            items = new List<Item>();
        }
        internal void AddItem(Item x)
        {
            this.items.Add(x);
        }
        public static Order<TDelivery, T> operator +(Order<TDelivery, T> X, Item x)
        {
            X.items.Add(x);
            return X;
        }

        internal Item this[string x]
        {
            get
            {
                foreach (Item X in this.items)
                {
                    if (x == X.product.vendorCode)
                        return X;
                    else
                    {
                        Console.WriteLine("Артикул продукта не найден в заказе");
                        return null;
                    }
                }
                
            }
        }

        internal void Show()
        {
            Console.WriteLine($"Заказ: {orderId}");
            Console.WriteLine(client.Show());
            Console.WriteLine("Состав заказа:");
            foreach(Item X in this.items)
                Console.WriteLine(X.Show());
        }

    }

}
