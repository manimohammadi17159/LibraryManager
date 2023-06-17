using Domain.Interface;
using Domain.Model;
using System.Data;

namespace Service
{

    public class UserManager : IUserManager
    {
        IUserRequest _userRequest;
        public UserManager(IUserRequest userRequest)
        {
            _userRequest = userRequest;
        }

        public User FindUser(string username)
        {
            var result = _userRequest.FindUser(username);
            return result;
        }

        public List<User> GetUsers()
        {
            List<User> result = new List<User>();

            DataTable users = _userRequest.SelectAllUser();

            foreach (DataRow row in users.Rows)
            {
                var user = new User();
                user.Id = Convert.ToInt32(row["Id"]);
                user.Name = row["Name"].ToString();
                user.Lastname = row["Lastname"].ToString();
                user.Username = row["Username"].ToString();
                user.Password = row["Password"].ToString();
                user.Credit = Convert.ToDecimal(row["Credit"]);

                result.Add(user);
            }

            return result;
        }

        public void NewInfo(User newInfo)
        {
            _userRequest.UpdateInfo(newInfo);
        }

        public void DeleteUser(int Id)
        {

            _userRequest.DeleteUser(Id);

        }
        public int GetUsersCount()
        {
            int result = _userRequest.CountUsers();

            return result;
        }
    }
}
