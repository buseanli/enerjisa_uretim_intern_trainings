using System;

namespace OOP
{
    public class Book
    {
        string _name;
        private string _author;
        private int _pagecount;

        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public int Pagecount
        {
            get => _pagecount;
            set => _pagecount = value;
        }
        public string GetDescription()
        {
            return $"{Name} by {Author}, {Pagecount} pages";
        }

        public string ISBN
        {
            get;
            set;
        }

        public decimal price
        {
            get;
            set;
        }
    }
}