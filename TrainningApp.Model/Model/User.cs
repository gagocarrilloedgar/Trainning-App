using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserNickname { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public int IMC { get; set; }

        public string gender { get; set; }

        public User()
        {

        }
    }
}
