using System;

namespace OOPString
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageCount { get; }
        
        public Book(string name, string author, int pages){
            Name = name;
            Author = author;
            PageCount = pages;
        }

        public override string ToString()
        {
            return $"Book: {Name}, {PageCount}, by {Author}";
        }

        public string ToString(char format)
        {
            if (format == 'B')
            {
                return $"Book: {Name}:{Author}";
            }
            else
            {
                return "Invalid format specified.";
            }
        }

    }
    
}