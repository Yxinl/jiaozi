﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiaoZi.Models
{
    interface IMall
    {
        IEnumerable<Books> GetBooks();
        IEnumerable<Books> GetBooksDetails(int id);
        IEnumerable<Books> Search(string search);
        IEnumerable<Books> GetBooksByAmount();
        IEnumerable<Books> GetBooksBycategory(string category);
        IEnumerable<Books> GetBooksByPrice();
        void AddBooks(Books books);
    }
}
