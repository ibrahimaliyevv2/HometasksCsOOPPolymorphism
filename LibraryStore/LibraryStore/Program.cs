using System;
using Models;

namespace LibraryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter book name:");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter book genre:");
            string bookGenre = Console.ReadLine();
            Console.WriteLine("Enter book author:");
            string bookAuthor = Console.ReadLine();
            Console.WriteLine("Enter book price:");
            double bookPrice = Convert.ToDouble(Console.ReadLine());

            Book book = new Book()
            {
                Name = bookName,
                Genre = bookGenre,
                Author = bookAuthor,
                Price = bookPrice
            };

            Console.WriteLine("Enter journal name:");
            string journalName = Console.ReadLine();
            Console.WriteLine("Enter journal company:");
            string journalAuthor = Console.ReadLine();
            Console.WriteLine("Enter journal price:");
            double journalPrice = Convert.ToDouble(Console.ReadLine());

            Journal journal = new Journal()
            {
                Name = journalName,
                Company = journalAuthor,
                Price = journalPrice
            };

            book.GetInfo();
            journal.GetInfo();

            Library library = new Library();
            library.AddProduct(book);
            library.AddProduct(journal);


            foreach (var item in library.GetProductsByPrice(2, 22))
            {
                item.GetInfo();
            }

            foreach (var item in library.GetProductsByName("lev"))
            {
                item.GetInfo();
            }
        }
    }
}
