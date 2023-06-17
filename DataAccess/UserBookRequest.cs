using Domain.Interface;
using Domain.Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserBookRequest : IUserBookRequest
    {
        IDbHelper _dbHelper;
        public UserBookRequest(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<Book> SelectUserBooks(string username)
        {
            int index = 0;
            List<Book> result = new List<Book>();
            string query = $"Select * From UserBook Where Username = '{username}'";
            SqlDataReader reader = null;

            DataTable dataTable = new DataTable();
            reader = _dbHelper.ExecuteQuery(query);

            dataTable.Load(reader);

            foreach (DataRow row in dataTable.Rows)
            {
                var book = new Book();

                book.Name = row["BookName"].ToString();
                book.ImageAddress = row["ImageAddress"].ToString();

                result.Add(book);
            }

            reader.Close();

            return result;
        }
        public void InsertNewUserBook(string username, Book newBook)
        {

            string query = $"Insert INTO UserBook(Username, BookName, ImageAddress)" +
                           $" Values('{username}','{newBook.Name}','{newBook.ImageAddress}')";

            _dbHelper.ExecuteNonQuery(query);

        }
        public bool FindUserBook(string username, string bookName)
        {
            bool result = false;

            string query = $"Select * From UserBook Where Username = '{username}'  AND BookName = '{bookName}'";
            var reader = _dbHelper.ExecuteQuery(query);

            if (reader.Read())
            {
                result = true;
            }

            reader.Close();

            return result;
        }
        public decimal TotalSales()
        {
            string query = "Select Sum(Price) From UserBook";
            SqlDataReader reader = _dbHelper.ExecuteQuery(query);
            decimal result = 0;

            if(reader.Read())
            {
                result += Convert.ToDecimal(reader[0]);
            }

            reader.Close();
            return result;

        }
        public int TotalBookSold()
        {
            int result = 0;
            string query = $"Select Count(Username) From UserBook";
            var reader = _dbHelper.ExecuteQuery(query);

            if (reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            reader.Close();

            return result;
        }

        public int BookCount()
        {
            int result = 0;
            string query = "Select Count(Name) From BookInfo";

            var reader = _dbHelper.ExecuteQuery(query);

            if (reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            reader.Close();

            return result;
        }
    }
}
