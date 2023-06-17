using Domain.Model;

namespace Domain.Interface
{
    public interface IUserBookManager
    {
        List<Book> GetUserBooks(string username);

        void NewUserBook(string username, Book newBook);

        bool FindUserBook(string username, string bookName);

    }
}
