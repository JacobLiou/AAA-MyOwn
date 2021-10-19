using NUnit.Framework;
using CartWebApi.Services;
using CartWebApi.Controllers;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace NunitMock
{
    public class Tests
    {
        private CartController controller;
        private Mock<IPaymentService> paymentServiceMock;
        private Mock<ICartService> cartServiceMock;

        private Mock<IShipmentService> shipmentServiceMock;
        private Mock<ICard> cardMock;
        private Mock<IAddressInfo> addressInfoMock;
        private List<CartItem> items;



        [SetUp]
        public void Setup()
        {
            cartServiceMock = new Mock<ICartService>();
            paymentServiceMock = new Mock<IPaymentService>();
            shipmentServiceMock = new Mock<IShipmentService>();
            cardMock = new Mock<ICard>();
            addressInfoMock = new Mock<IAddressInfo>();
            items = new List<CartItem>();

            var cartItemMock = new Mock<CartItem>();
            cartItemMock.Setup(item => item.Price).Returns(10);

            items.Add(cartItemMock.Object);



            cartServiceMock.Setup(cartService => cartService.Items()).Returns(items.AsEnumerable());
            cartServiceMock.Setup(cartService => cartService.Total()).Returns(items.Sum(item => item.Price));

            controller = new CartController(cartServiceMock.Object, paymentServiceMock.Object, shipmentServiceMock.Object);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void ShouldReturnCharged()
        {
            //aRRANGE ╪сио Setup()
            paymentServiceMock.Setup(p => p.Charge(It.IsAny<double>(), cardMock.Object)).Returns(true);

            //aCt
            var result = controller.CheckOut(cardMock.Object, addressInfoMock.Object);

            // assert
            // myInterfaceMock.Verify((m => m.DoesSomething()), Times.Once());
            shipmentServiceMock.Verify(s => s.Ship(addressInfoMock.Object, items.AsEnumerable()), Times.Once());

            Assert.AreEqual("10", result);

        }
    }
}