using DataAccess;
using Domain.Interface;
using Domain.Model;

namespace Service
{
    public class SignUp : ISignUp
    {
        private IUserRequest _userRequest;
        public SignUp(IUserRequest userRequest)
        {
            _userRequest = userRequest;
        }
        public void Start(User newUser)
        {
            _userRequest.InsertNewUser(newUser);                       
        }
        public bool CheckBeUniqe(string userName)
        {
            bool result;

            var user = _userRequest.FindUser(userName);

            result = user == null ? true : false;

            return result;
        }

    }
}