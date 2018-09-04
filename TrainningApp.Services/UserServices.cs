using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Services.Interface
{
    public class UserServices : IUserServices
    {
        public double GetIMCByUserParameters(string weigth, string heigth)
        {
            int weigthInt = -1;
            int heigthInt = 1;
            double result = 0;

            if(int.TryParse(weigth,out weigthInt) && int.TryParse(heigth,out heigthInt))
            {
                result = ( Convert.ToDouble(weigthInt) / (((Convert.ToDouble(heigthInt))/100) * ((Convert.ToDouble(heigthInt)/100))));
            }
            else { }

            return result;
        }
    }
}
