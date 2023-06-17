﻿using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IBookRequest
    {
        void InsertNewBook(Book book);
        List<Book> SelectBooks();
        Book FindBook(string name);

    }
}
