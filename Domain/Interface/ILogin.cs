using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ILogin
    {
        User StartAsUser(string userName, string password);
        bool StartAsAdmin(string userName, string password);

    }
}
