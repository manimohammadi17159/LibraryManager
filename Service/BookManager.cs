using Domain.Interface;
using Domain.Model;
using System.Data.SqlClient;

namespace Service
{
    public class BookManager : IBookManager
    {
        IBookRequest _bookRequest;
        public BookManager(IBookRequest bookRequest)
        {
            _bookRequest = bookRequest;
        }
        
        public List<Book> GetAllBooks()
        {
            List<Book> result = new List<Book>();
            result = _bookRequest.SelectBooks();
            return result;
        }

        public void NewBook(Book newBook)
        {
            _bookRequest.InsertNewBook(newBook);
        }
        public Book SearchBook(string name)
        {
            var result = _bookRequest.FindBook(name);
            return result;
        }
    }
}
