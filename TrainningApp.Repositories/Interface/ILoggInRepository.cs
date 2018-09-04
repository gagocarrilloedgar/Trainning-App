using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Repositories.Interface
{
    public interface ILoggInRepository
    {
        bool LoggInUser(string username, string password);

        bool IsTheUsernameAvailable(string username);

        void PurgeUser();
    }
}
