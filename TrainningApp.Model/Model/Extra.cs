using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Model.Model
{
    public class Extra
    {
        public int ExtraID{ get; set; }

        public List<Element> ElementList{ get; set; }

        public Extra()
        {
            ElementList = new List<Element>();
        }
    }
}
