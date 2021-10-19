using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartWebApi.Services;

namespace CartWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IPaymentService _paymentService;
        private readonly IShipmentService _shipmentService;

        public CartController(
          ICartService cartService,
          IPaymentService paymentService,
          IShipmentService shipmentService
        )
        {
            _cartService = cartService;
            _paymentService = paymentService;
            _shipmentService = shipmentService;
        }

        [HttpPost]
        public string CheckOut(ICard card, IAddressInfo addressInfo)
        {
            //OOP
            //SOLID Interface DI IOC的典范

            //计价
            var items = _cartService.Items();
            var total = _cartService.Total();

            //付费
            if (_paymentService.Charge(total, card))
            {
                //配送
                _shipmentService.Ship(addressInfo, items);
            }

            return$"{total}";
        }
    }
}
