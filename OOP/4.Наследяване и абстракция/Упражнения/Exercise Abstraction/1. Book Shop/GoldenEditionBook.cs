using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Book_Shop
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string title, string author, decimal price) 
            :base(title,author,price)
        {
           
        }
        public override decimal Price
        {
            get 
            {
                return base.Price*1.3m;
            }
            set
            {
                base.Price = value;
            }
           
        }
        public override string ToString()
        {
            return string.Format("-Type: GoldenEditionBook \n-Title: {0} \n-Author: {1} \n-Price: {2:F2}", this.Title, this.Author, this.Price);
        }
    }
}
