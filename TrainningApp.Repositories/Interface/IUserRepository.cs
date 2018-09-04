using System.Collections.Generic;
using TrainningApp.Model;
using TrainningApp.Model.Model;

namespace TrainningApp.Repositories.Interface
{
    public interface IUserRepository
    {
        void AddUser(string name, string surname, string age, string weigth, string heigth, string password, string username, string imc);

        User GetUserByUserName(string username, string password);

        void DelteUser(string UserToDelete);

        void ModifyUserByUsername(string name, string surname, string age, string weigth, string heigth, string password, string username, string imc,string actualuser);

        List<User> GetUsers();

        string GetActualUserNickName();

        string GetActualUserPassword();


    }
}
