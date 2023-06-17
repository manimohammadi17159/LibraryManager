using Domain.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IUserRequest
    {
        User FindUser(string userName);
        User FindAdmin(string username);
        User FindUserWithId(int Id);
        void InsertNewUser(User newUser);
        DataTable SelectAllUser();
        void UpdateInfo(User newInfo);
        void DeleteUser(int id);
        int CountUsers();
    }
}
