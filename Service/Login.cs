using Domain.Interface;
using Domain.Model;

namespace Service
{
    public class Login : ILogin
    {
        private IUserRequest _userRequest;
        public Login(IUserRequest userRequest)
        {
            _userRequest = userRequest;
        }

        public User StartAsUser(string username, string password)
        {
            User result = new();

            result = FindUser(username);

            if (result != null)
            {
                result = password == result.Password ? result : null;
            }

            return result;
        }
        public bool StartAsAdmin(string username, string password)
        {
            bool result = false;
            User checkInfo = new();

            checkInfo = FindAdmin(username);

            if (checkInfo != null)
            {
                result = password == checkInfo.Password ? true : false;
            }

            return result;
        }
        private User FindUser(string userName)
        {
            User result = null;

            result = _userRequest.FindUser(userName);

            return result;
        }
        private User FindAdmin(string userName)
        {
            User result = _userRequest.FindAdmin(userName);
            return result;
        }

    }
}
