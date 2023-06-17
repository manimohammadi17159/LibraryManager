using Domain.Model;

namespace Domain.Interface
{
    public interface ISignUp
    {
        void Start(User newUser);
        bool CheckBeUniqe(string userName);

    }
}
