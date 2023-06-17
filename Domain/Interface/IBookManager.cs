using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IBookManager
    {
        public List<Book> GetAllBooks();
        public void NewBook(Book newBook);
        public Book SearchBook(string name);

    }
}
