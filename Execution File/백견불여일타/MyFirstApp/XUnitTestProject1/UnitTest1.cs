using System;
using Xunit;
using AddLib;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double a = 3;
            double b = 4;
            double expected = 7;
            var calc = new AddClass();
            var actual = calc.double_add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int a = 3;
            int b = 4;
            int expected = 7;
            var calc = new AddClass();
            var actual = calc.int_add(a, b);
            Assert.Equal(expected, actual);
        }
    }
}
