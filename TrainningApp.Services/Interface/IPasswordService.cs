using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainningApp.Services.Interface
{
    public interface IPasswordService
    {
        System.Security.SecureString GetPassword { get; }
    }
}
