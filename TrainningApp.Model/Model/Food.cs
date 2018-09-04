using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Model.Model;

namespace TrainningApp.Model
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }
        public List<Dinner> DinerList { get; set; }
        public List<Lunch> LunchList { get; set; }
        public List<Breakfast> BreakfasList { get; set; }

        public Food()
        {
            DinerList = new List<Dinner>();
            BreakfasList = new List<Breakfast>();
            LunchList = new List<Lunch>();
        }
    }
}
