using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace skill7final
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Delivery
    {
        public string Address;
        public abstract void Delivery1();
        Random random = new Random();
    }

    class HomeDelivery : Delivery
    {
        public override void Delivery1()
        {
            string Address = Console.ReadLine();
            Console.WriteLine(Address);
        }
    }

    class PickPointDelivery : Delivery
    {
        public override void Delivery1()
        {
            Random random = new Random();
            string[] addresspoint = new string[random.Next(50)];
            foreach (string s in addresspoint) { Console.WriteLine(s); }
            Console.WriteLine($"Выберите аресс доставки в виде числа от 1 до {addresspoint.Length}");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(addresspoint[count]);
        }
    }

    class ShopDelivery : Delivery
    {
        public override void Delivery1()
        {
            Random random = new Random();
            string[] addressshop = new string[random.Next(15)];
            foreach (string s in addressshop){ Console.WriteLine(s); }
            Console.WriteLine($"Выберите аресс доставки в виде числа от 1 до {addressshop.Length}");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine(addressshop[count]);
        }
    }

    class Order<TDelivery,
    TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
        public Product product {  get; set; }
        // ... Другие поля
    }
    abstract class Product
    {
        public string product { get; set; }
        public abstract void Package();
    }
    class FragleProduct<T>:Product
    {
        public override void Package()
        {
            Console.WriteLine("Упаковать дополнительную защиту ");
        }
    }
    class PerishableProduct<T> : Product 
    {
        public override void Package()
        {
            Console.WriteLine("Поместить в холодильник");
        }
    }
}
