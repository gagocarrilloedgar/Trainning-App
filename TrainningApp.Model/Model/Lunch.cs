using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Model
{
    public class Lunch
    {
        [Key]
        public int LunchId { get; set; }

        public List<Element> ElementList { get; set; }

        public Lunch()
        {
            ElementList = new List<Element>();
        }
    }
}
