using LINQ_Task1.Models;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace LINQ_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Customers = new List<Customer>()
            {
    new Customer
                {

        Id = 1,
        Name = "Malak",
        Email = "malak@example.com",
        Phone = "123-456-7890",
        City = "Nablus",
        PurchasedProducts=new List<Product>
        {
            new Product {Id=1,ProductName="desktop",Price=4000},
            new Product {Id=2,ProductName="lap",Price=2500}

        },
    },
    new Customer
    {
        Id = 2,
        Name = "Ahmed",
        Email = "Ahmed@example.com",
        Phone = "987-654-3210",
        City = "Qalqilia",
         PurchasedProducts=new List<Product>
        {
            new Product {Id=3,ProductName="Iphone",Price=3000},

        },
    },
     new Customer
    {
        Id = 3,
        Name = "omar",
        Email = "omar@example.com",
        Phone = "987-654-3210",
        City = "tubas",
          PurchasedProducts=new List<Product>
        {
            new Product {Id=4,ProductName="Keyboar",Price=300},

        },
    },
       new Customer
    {
        Id = 4,
        Name = "Tariq",
        Email = "tariq@example.com",
        Phone = "987-654-3210",
        City = "Nablus",
          PurchasedProducts=new List<Product>
        {
            new Product {Id=5,ProductName="telephone",Price=1000},

        },
       }

            };
            Console.WriteLine("1-");
           var results=Customers.Where(c=>c.City=="Nablus").ToList();
            foreach(var res in results)
            {
                Console.WriteLine(res.Name);
            }
            Console.WriteLine("2-");
            var names = Customers.ToList();
            foreach(var name in names)
            {
                Console.WriteLine(name.Name);
            }
            Console.WriteLine("3-");
            var names2 = Customers.OrderBy(c => c.Name).ToList();
            foreach (var item in names2)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("4-");
            var first = Customers.FirstOrDefault();
            Console.WriteLine(first.Name);

            Console.WriteLine("5-");
            var single = Customers.Single(c=>c.Id==1);
            Console.WriteLine(single.Name);

            Console.WriteLine("6-");
            var sumPrice = Customers.SelectMany(c=>c.PurchasedProducts).Sum(p=>p.Price);
            Console.WriteLine(sumPrice);

            Console.WriteLine("7-");
            var test = Customers.Any(c=>c.City== "Qalqilia");
            Console.WriteLine(test);

            Console.WriteLine("8-");
            var group = Customers.GroupBy(c => c.City).ToList();
            foreach(var item in group)
            {
                Console.WriteLine("city:");
                Console.WriteLine(item.Key);
                foreach(var coustomer in item)
                {
                    Console.WriteLine(coustomer.Name);
                }
                Console.WriteLine("-----------");

            }

            Console.WriteLine("9-");
            var first3 = Customers.Take(3);
            foreach(var f in first3)
            {
                Console.WriteLine(f.Name);
            }
        }
    }
}