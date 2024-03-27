using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation__class
{
    internal class Library
    {
        Book[] Books = new Book[] { };

        public Library()
        {

        }

        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }



        public Book[] GetFilteredBooks(string genre)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Genre == genre)
                {
                    Console.WriteLine($"Name:{Books[i].Name}\n" +
                                      $"Price:{Books[i].Price}\n" +
                                      $"No:{Books[i].No}\n" +
                                      $"Count:{Books[i].Count}\n" +
                                      $"Genre:{Books[i].Genre}");
                    Console.WriteLine("--------------------------------");
                }
            }
            return Books;
        }
        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price >= minPrice && Books[i].Price <= maxPrice)
                {
                    Console.WriteLine($"Name:{Books[i].Name}\n" +
                                      $"Price:{Books[i].Price}\n" +
                                      $"No:{Books[i].No}\n" +
                                      $"Count:{Books[i].Count}\n" +
                                      $"Genre:{Books[i].Genre}");
                    Console.WriteLine("-----------------------------");
                }
            }
            return Books;
        }

        public void ShowAllBooks()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"{Books[i].ShowInfo()}");
                Console.WriteLine("----------------------------");

            }

        }
    }
}
