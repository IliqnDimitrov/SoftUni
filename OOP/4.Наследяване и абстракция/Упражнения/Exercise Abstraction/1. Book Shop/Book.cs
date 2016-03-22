using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Book_Shop
{
    class Book
    {
        private string title;
        private string author;
        private decimal price;

        public string Title 
        {
            get { return this.title; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be null");
                }
                this.title = value;
            } 
        }
        public string Author
        {
            get { return this.author; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Author cannot be null");
                }
                this.author = value;
            }
        }
        public virtual decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative");
                }
                this.price = value;
            }
        }
        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("-Type: Book \n-Title: {0} \n-Author: {1} \n-Price: {2}",this.title,this.author,this.price);
        }
    }
}
