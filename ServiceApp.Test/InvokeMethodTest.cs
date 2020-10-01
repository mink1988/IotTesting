using System;
using Xunit;
using ServiceApp;

namespace ServiceApp.Test
{
    public class InvokeMethodTest
    {
        [Fact]
        public void InvokeMethod()
        {
            var count = 2;
            var sut = new Mink();

            var actual = sut.Fiska(count);

            var expected = 7;
            Assert.Equal(actual, expected);
        }
    }
}
