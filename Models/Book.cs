using System;
namespace Models
{
    public class Book:Product
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Book name: {Name}, Book author: {Author}, Book genre: {Genre}, Book price: {Price}");
        }
    }
}
