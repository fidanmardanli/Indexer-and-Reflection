using System;
namespace IndexerAndReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();    
            Book book = new Book
            {
                Id = 1,
                Name = "Xosrov ve shirin",
                Author = "Nizami Gencevi"
            };

            Book book2 = new Book
            {
                Id = 2,
                Name = "Isgendername",
                Author = "Nizami Gencevi"
            };

            Book book3 = new Book
            {
                Id = 3,
                Name = "7 gozel",
                Author = "Nizami Gencevi"
            };

            books.Add(book);
            books.Add(book2);
            books.Add(book3);

            //foreach (var item in books)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(GetBookById(books,2));

            var result = GetBooksById(2, books);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(book);

            //string str = "";
            //Console.WriteLine(str.GetType());

            //Console.WriteLine(GetBook(book));
        }

        public static Book GetBook(Book book) => book; 

        public static List<Book> GetBooksById(int id, List<Book> books)
        {
            return books.FindAll(m => m.Id != id);
        }

        public static string GetBookById(List<Book> books, int id)
        {
            return books.Find(m => m.Id == id);
        }
    }
}