using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer= new Customer();
            customer.id=1;
            customer.name = "Taner";

            Console.ReadKey();
        }
    }
    class Customer
    {
        public Customer(int id,string firstName,string lastName,string city)
        {
            id=id;
            name=firstName;
            lastName = lastName;
            city = city;

        }
        //default constructors
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }
    }
}
