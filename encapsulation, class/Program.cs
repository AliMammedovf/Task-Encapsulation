namespace encapsulation__class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Name = "Relsler uzerinde uzanmis adam";
            book1.No = 1;
            book1.Count = 3;
            book1.Genre = "romantic";
            book1.Price = 12;

            Book book2 = new Book();
            book2.Name = "Mavi qatarin sirri";
            book2.No = 2;
            book2.Count = 5;
            book2.Genre = "dedective";
            book2.Price = 9;

            Book book3 = new Book();
            book3.Name = "Saatlar";
            book3.No = 3;
            book3.Count = 2;
            book3.Genre = "dedective";
            book3.Price = 7.50;

            Book book4 = new Book();
            book4.Name = "Intikam";
            book4.No = 4;
            book4.Count = 8;
            book4.Genre = "fantastic";
            book4.Price = 13.50;

            Book book5 = new Book();
            book5.Name = "Ali ve Nino";
            book5.No = 5;
            book5.Count = 10;
            book5.Genre = "romantic";
            book5.Price = 6.50;


            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);



            library.ShowAllBooks();



            Console.WriteLine("Janri daxil edin:");
            string genre = Console.ReadLine();

            Console.WriteLine(" ");
            library.GetFilteredBooks(genre);


            Console.WriteLine("minPrice daxil edin:");
            int minPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("maxPrice daxil edin");
            int maxPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            library.GetFilteredBooks(minPrice, maxPrice);
        }
    }
}
