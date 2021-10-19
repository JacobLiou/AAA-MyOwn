using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartWebApi.Models;

namespace CartWebApi.Services
{
    public interface IShipmentService
    {
        void Ship(IAddressInfo addressInfo, IEnumerable<CartItem> items);
    }
}
