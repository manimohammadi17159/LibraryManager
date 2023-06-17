using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IUserManager
    {
        User FindUser(string name);
        List<User> GetUsers();
        void NewInfo(User newInfo);
        void DeleteUser(int Id);
        int GetUsersCount();
    }
}
