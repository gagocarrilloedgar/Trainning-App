using System.Data.Entity;
using TrainningApp.Model.Model;

namespace TrainningApp.Model
{
    public class DataBaseContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserUsingTheApp> ActualUser { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Breakfast> Breakfasts { get; set; }
        public DbSet<Lunch> Lunchs { get; set; }
        public DbSet<Dinner> Dinners { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<Element> Elements { get; set; }

    }
}
