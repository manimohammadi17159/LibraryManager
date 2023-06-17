using Domain.Model;
using System.Data.SqlClient;

namespace Domain.Interface
{
    public interface IUserBookRequest
    {
        List<Book> SelectUserBooks(string username);

        void InsertNewUserBook(string username, Book newBook);

        bool FindUserBook(string username, string bookName);

        decimal TotalSales();

        int TotalBookSold();

        int BookCount();
    }
}
