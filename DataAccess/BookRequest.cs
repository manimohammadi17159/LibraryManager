using Domain.Interface;
using Domain.Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BookRequest : IBookRequest
    {
        private IDbHelper _dbHelper;
        public BookRequest(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public List<Book> SelectBooks()
        {
            int index = 0;
            List<Book> result = new List<Book>();
            string query = $"Select * From BookInfo";
            SqlDataReader reader = null;

            DataTable dataTable = new DataTable();
            reader = _dbHelper.ExecuteQuery(query);

            dataTable.Load(reader);

            foreach (DataRow row in dataTable.Rows)
            {
                var book = new Book();
                book.Code = Convert.ToInt32(row["Code"]);
                book.Name = row["Name"].ToString();
                book.ImageAddress = row["ImageAddress"].ToString();

                result.Add(book);
            }

            reader.Close();

            return result;
        }

        public void InsertNewBook(Book newBook)
        {

            string query = $"Insert INTO BookInfo(Name, Writer, Translator, ImageAddress, Price)" +
                           $" Values('{newBook.Name}','{newBook.Writer}','{newBook.Translator}'," +
                           $"'{newBook.ImageAddress}','{newBook.Price}')";

            _dbHelper.ExecuteNonQuery(query);

        }
        public Book FindBook(string name)
        {
            string query = $"Select * From BookInfo Where Name = '{name}'";
            SqlDataReader reader = _dbHelper.ExecuteQuery(query);

            Book result = new();

            if (reader.Read())
            {
                result.Code = reader.GetInt32(0);
                result.Name = reader.GetString(1);
                result.ImageAddress = reader.GetString(2);
                result.Translator = reader.GetString(3);
                result.Writer = reader.GetString(4);
                result.Price = reader.GetDecimal(5);
            }
            reader.Close();

            return result;

        }



    }
}
