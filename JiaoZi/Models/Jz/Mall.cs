﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JiaoZi.Models
{
    public class Mall:IMall
    {
        jiaoziEntities db = new jiaoziEntities();
        //获取全部图书
       public IEnumerable<Books> GetBooks()
        {
            var books = db.Books.ToList();
            return books;
        }
        //获得单独一本书的详情
        public IEnumerable<Books> GetBooksDetails(int id)
        {
            var bookdetail = from p in db.Books
                             where p.BookID == id
                             select p;
            return bookdetail;
        }
        //根据书名或者作者名进行搜索
        public IEnumerable<Books> Search(string search)
        {
            var sear = from p in db.Books
                       where p.BookName.Contains(search) || p.BookAuthor.Contains(search)
                       select p;
            return sear.ToList();
        }
        //升序排列 找出数量最少的三本 热销榜
        public IEnumerable<Books> GetBooksByAmount()
        {
            var AmountBooks = (from p in db.Books
                               orderby p.Amount ascending
                               select p).Take(3);
            return AmountBooks;
                           
        }
        //各类书分类显示
       public IEnumerable<Books> GetBooksBycategory(string category)
        {
            var books = (from p in db.Books
                        where p.Category == category
                        select p);
            return books.ToList();
        }
        public IEnumerable<Books> GetBooksByPrice()
        {
            var books = (from p in db.Books
                         orderby p.Price ascending
                         select p).Take(5);
            return books.ToList();
        }
        public void AddBooks(Books books)
        {
            db.Books.Add(books);
            db.SaveChanges();
        }
    }
}