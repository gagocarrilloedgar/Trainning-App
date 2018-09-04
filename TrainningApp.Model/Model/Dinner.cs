using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Model
{
    public class Dinner
    {
        [Key]
        public int DinnerId { get; set; }

        public List<Element> ElementList { get; set; }

        public Dinner()
        {
            ElementList = new List<Element>();
        }
    }
}
