using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Model
{
    public class Element
    {
        [Key]
        public int ElementID { get; set; }

        public string Name { get; set; }

        public int EnergeticValue { get; set; }

        public int proteins { get; set; }

        public int Fats { get; set; }

        public int Carbs { get; set; }

        public Element()
        {

        }
    }
}
