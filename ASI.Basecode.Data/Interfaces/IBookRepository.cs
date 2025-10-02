﻿using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Interfaces
{
    public interface IBookRepository
    {
        List<Book> ViewBooks();

        void AddBook(Book book);

        Book GetBook(int id);

        void UpdateBook(Book book);

        void DeleteBook(int id);
    }
}
