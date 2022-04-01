using System;
namespace Models
{
    public class Journal:Product
    {
        public string Company { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Journal name: {Name}, Journal company: {Company}, Journal price: {Price}");
        }
    }
}
