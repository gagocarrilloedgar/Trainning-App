﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Services.Interface
{
    public interface IUserServices
    {
        double GetIMCByUserParameters(string weigth, string heigth);

        

    }
}
