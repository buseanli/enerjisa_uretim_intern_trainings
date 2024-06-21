using System;

namespace OOPString
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;
            Console.WriteLine(x.ToString());

            Book b1 = new Book("Grapes of Wrath", "John Steinbeck", 353); 
            Console.WriteLine(b1.ToString('B'));
        }
    }
}