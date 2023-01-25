using System;

namespace BookDetails
{
    struct Books
    {
        public string title;
        public int price;
        public int book_id;
        public enum bookType { Magazine, Novel, ReferenceBook, Miscellaneous };

        public void AcceptDetails()
        {
            Console.WriteLine("Enter book title");
             title = Console.ReadLine();
            Console.WriteLine("Enter book price");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter bookID");
            book_id = Convert.ToInt32(Console.ReadLine());
            
        }
        public void Display()
        {
            Console.WriteLine("Title : {0}", title);
            Console.WriteLine("Price : {0}", price);
            Console.WriteLine("Book_id :{0}", book_id);
            bookType myvar = bookType.Magazine;
            Console.WriteLine("Book type:{0}",myvar);
            }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Books Book1 = new Books();
            Book1.AcceptDetails();
            Book1.Display();
        }
    }
}
