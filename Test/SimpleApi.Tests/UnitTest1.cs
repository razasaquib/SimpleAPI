using System;
using Xunit;
using SimpleApi;
using SimpleApi.Controllers;

namespace SimpleApi.Tests
{
    public class UnitTest1
    {
        valueController obj = new valueController();
        [Fact]
        public void Test1()
        {
              var ctr =  obj.Get(1);
              Assert.Equal("Saquib",ctr);
        }
    }
}
