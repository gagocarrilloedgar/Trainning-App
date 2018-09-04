using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Model.Model
{
    public class Breakfast
    {
        [Key]
        public int BreakfastID { get; set; }

        public List<Element> ElementList { get; set; }

        public Breakfast()
        {
            ElementList = new List<Element>();
        }
    }
}
