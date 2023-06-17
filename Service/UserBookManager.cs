using Domain.Interface;
using Domain.Model;

namespace Service
{
    public class UserBookManager : IUserBookManager
    {
        IUserBookRequest _userBookRequest;
        public UserBookManager(IUserBookRequest userBookRequest)
        {
            _userBookRequest = userBookRequest;
        }

        public List<Book> GetUserBooks(string username)
        {
            var result = _userBookRequest.SelectUserBooks(username);

            return result;
        }

        public void NewUserBook(string username, Book newBook)
        {
            _userBookRequest.InsertNewUserBook(username, newBook);
        }
        public bool FindUserBook(string username, string bookName)
        {
            bool result = _userBookRequest.FindUserBook(username, bookName);

            return result;

        }
    }
}
