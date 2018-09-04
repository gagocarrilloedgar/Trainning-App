using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Model;
using TrainningApp.Model.Model;
using TrainningApp.Repositories.Interface;

namespace TrainningApp.Repositories
{
    public class LoggInRepository : ILoggInRepository
    {
        DataBaseContext _db = new DataBaseContext(); // Creating de DataBase For the LoggInView

        public bool IsTheUsernameAvailable(string username)
        {
            var userAvailable = false;

            try
            {
                var actualUser = (from user in _db.Users where user.UserNickname == username select user).First();
                userAvailable = true;
            }
            catch(Exception)
            {
                userAvailable = false;
            }
            return userAvailable;
        }

        public bool LoggInUser(string username, string password)
        {
            bool access = false;
            #region Cleaning the space first
            PurgeUser();
            #endregion

            #region Keeping The Logged User
            if ((String.IsNullOrWhiteSpace(username) == false || String.IsNullOrWhiteSpace(password) == false))
            {
                var user = new UserUsingTheApp
                {
                    UserNickname = username,
                    Password = password,
                };

                _db.ActualUser.Add(user);
                _db.SaveChanges();

                access = true;
            }
            else
            {
                access = false;
            }
            #endregion

            return access;
        }

        public void PurgeUser()
        {
            var users = from actualuser in _db.ActualUser where actualuser.UserId != null select actualuser;

            foreach (var user in users)
            {
                _db.ActualUser.Remove(user);
            }
            _db.SaveChanges();
        }
    }
}
