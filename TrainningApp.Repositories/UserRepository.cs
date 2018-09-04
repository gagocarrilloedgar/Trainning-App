using System;
using System.Collections.Generic;
using System.Linq;
using TrainningApp.Model;
using TrainningApp.Model.Model;
using TrainningApp.Repositories.Interface;

namespace TrainningApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        DataBaseContext _db = new DataBaseContext();

        public void AddUser(string name, string surname, string age, string weigth, string heigth, string password, string username, string imc)
        {
            int ageInt = -1;
            int weigthInt = -1;
            int heigthInt = -1;
            int imcInt = -1;

            var user = new User();
            if (int.TryParse(age, out ageInt) && int.TryParse(weigth, out weigthInt) && int.TryParse(heigth, out heigthInt) && int.TryParse(imc, out imcInt))
            {

                user.Name = name;
                user.Surname = surname;
                user.Age = ageInt;
                user.Weight = weigthInt;
                user.Height = heigthInt;
                user.IMC = imcInt;
                user.Password = password;
                user.UserNickname = username;
            }
            else
            {
                throw new NotImplementedException();
            }

            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void DelteUser(string UserToDelete)
        {
            throw new NotImplementedException();
        }

        public User GetUserByUserName(string username, string password)
        {
            var actualuser = (from user in _db.Users where username == user.UserNickname && user.Password == password select user).First();

            return actualuser;
        }

        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }

        public void ModifyUserByUsername(string name, string surname, string age, string weigth, string heigth, string password, string username, string imc,string actualuser)
        {

            int ageInt = -1;
            int weigthInt = -1;
            int heigthInt = -1;
            int imcInt = -1;
            var selecteduser = (from user in _db.Users where user.UserNickname == actualuser select user).First();

            if (int.TryParse(age, out ageInt) && int.TryParse(weigth, out weigthInt) && int.TryParse(heigth, out heigthInt) && int.TryParse(imc, out imcInt))
            {

                selecteduser.Name = name;
                selecteduser.Surname = surname;
                selecteduser.Age = ageInt;
                selecteduser.Weight = weigthInt;
                selecteduser.Height = heigthInt;
                selecteduser.IMC = imcInt;
                selecteduser.Password = password;
                selecteduser.UserNickname = username;
            }
            else
            {
                throw new NotImplementedException();
            }

            _db.SaveChanges();
        }

        public string GetActualUserNickName()
        {
            var actualNickName = (from user in _db.ActualUser where user.Password != null select user.UserNickname).First();

            return actualNickName;
        }

        public string GetActualUserPassword()
        {
            var actualPassword = (from user in _db.ActualUser where user.Password != null select user.Password).First();

            return actualPassword;
        }


    }
}
