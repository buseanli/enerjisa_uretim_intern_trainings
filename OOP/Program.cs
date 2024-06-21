using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] arg)
        {
            Book b1 = new Book("war and peace", "leo tolstoy", 825);
            Book b2 = new Book("grapes of wrath", "john", 454);
            b1.ISBN = "32234324";
            b1.price = 350.0m;
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.price);
            
            Console.WriteLine(b1.GetDescription());
        }
    }
}