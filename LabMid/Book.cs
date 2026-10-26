using System;
using System.Collections.Generic;
using System.Text;

namespace LabMid
{
    internal class Book
    {
       public  string? title, author = null;
       public double price;
       public int copies;

        public Book()
        {
           title = "";
          author = "";
           price = 0;
         copies = 0;
      }

    }
}
