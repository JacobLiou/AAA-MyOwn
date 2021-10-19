using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CartWebApi.Services
{
    public interface CartItem
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }

    public interface IAddressInfo
    {
        public string Street { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
