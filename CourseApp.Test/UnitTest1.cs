using System;
using Xunit;
using laba2;
namespace CourseApp.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var res = Program.y(0, 0, 0);
            Assert.Equal(0, res);
        }
        [Fact]
        public void Test2()
        {
            var res = Program.y(1, 0, 0);
            Assert.Equal(0, res);
        }
        [Fact]
        public void Test3()
        {
            var res = Program.y(0, 1, 0);
            Assert.Equal(0, res);
        }
        [Fact]
        public void Test4()
        {
            var res = Program.y(0, 2, 0);
            Assert.Equal(0, res);
        }
        [Fact]
        public void Test5()
        {
            var res = Program.y(1, -1, 0);
            Assert.Equal(0.325, res, 3);
        }
        [Fact]
        public void Test6()
        {
            var res = Program.y(1, 0, 1);
            Assert.Equal(1.649, res, 3);
        }
        [Fact]
        public void Test7()
        {
            var res = Program.y(-4, 1, 1);
            Assert.Equal(Double.NaN, res);
        }
        [Fact]
        public void Test8()
        {
            var res = Program.y(1, -6, 1);
            Assert.Equal(1.777, res, 3);
        }
    }
}
