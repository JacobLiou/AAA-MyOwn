using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartWebApi.Services
{
    public interface IPaymentService
    {
        bool Charge(double total, ICard card);
    }
}
