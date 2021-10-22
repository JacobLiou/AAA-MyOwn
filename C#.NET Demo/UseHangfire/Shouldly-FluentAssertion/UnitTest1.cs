using System;
using Xunit;
using Shouldly;
using FluentAssertions;

namespace Shouldly_FluentAssertion
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int hundred = 100;
            Assert.Equal(100, hundred);

            Should.Equals(100, hundred);
        }

        [Fact]
        public void TestShouldly()
        {
            string message = "haha";
            message.ShouldNotBe("");
            message.ShouldBe("h" + "aha");
        }

        [Fact]
        public void TestFluentAssertions()
        {
            ///AAA×¼Ôò Arrange act assert
            string actual = "ABCDEFGHI";
            actual.Should().StartWith("AB").And.EndWith("HI");
        }
    }
}
