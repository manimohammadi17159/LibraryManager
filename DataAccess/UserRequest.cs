using Domain.Interface;
using Domain.Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class UserRequest : IUserRequest
    {
        private IDbHelper _dbHelper;
        public UserRequest(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public void DeleteUser(int id)
        {
            string query = $"Delete From UserInfo Where Id = {id}";
            _dbHelper.ExecuteNonQuery(query);
        }

        public User FindUser(string userName)
        {
            User result = null;
            string query = $"Select * From UserInfo Where Username= '{userName}'";
            SqlDataReader reader;

            reader = _dbHelper.ExecuteQuery(query);

            if (reader.Read())
            {
                result = new User()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Lastname = reader.GetString(2),
                    Username = reader.GetString(3),
                    Password = reader.GetString(4),
                    Credit = reader.GetDecimal(5)
                };
            }
            reader.Close();

            return result;
        }
        public User FindUserWithId(int Id)
        {
            User result = null;
            string query = $"Select * From UserInfo Where Id= '{Id}'";
            SqlDataReader reader = null;

            reader = _dbHelper.ExecuteQuery(query);

            if (reader.Read())
            {
                result = new User()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Lastname = reader.GetString(2),
                    Username = reader.GetString(3),
                    Password = reader.GetString(4),

                };
            }
            reader.Close();

            return result;
        }
        public void InsertNewUser(User newUser)
        {
            string query = $"Insert INTO UserInfo(Username, Password, Name, Lastname)" +
                           $" Values('{newUser.Username}','{newUser.Password}','{newUser.Name}','{newUser.Lastname}')";

            _dbHelper.ExecuteNonQuery(query);

        }

        public DataTable SelectAllUser()
        {
            int index = 0;
            List<Book> books = new List<Book>();

            string query = $"Select * From UserInfo";

            SqlDataReader reader = _dbHelper.ExecuteQuery(query);

            DataTable result = new DataTable();

            result.Load(reader);

            reader.Close();

            return result;
        }
        public void UpdateInfo(User newInfo)
        {

            string query = $"Update UserInfo SET Name = '{newInfo.Name}', Lastname = '{newInfo.Lastname}'," +
                           $"Username = '{newInfo.Username}', Password = '{newInfo.Password}', Credit = '{newInfo.Credit}'" +
                           $"WHERE Username = '{newInfo.Username}'";

            _dbHelper.ExecuteNonQuery(query);
        }
        public int CountUsers()
        {
            string query = "Select Count(Username) From UserInfo";
            var reader = _dbHelper.ExecuteQuery(query);

            int result = 0;

            if (reader.Read())
            {
                result = Convert.ToInt32(reader[0]);
            }
            reader.Close();

            return result;
        }

        public User FindAdmin(string username)
        {
            User result = new();
            string query = $"Select * From AdminUser Where Username = '{username}'";

            var reader = _dbHelper.ExecuteQuery(query);
            if (reader.Read())
            {
                result.Username = reader.GetString(0);
                result.Password = reader.GetString(1);
            }

            reader.Close();
            return result;
        }
    }
}