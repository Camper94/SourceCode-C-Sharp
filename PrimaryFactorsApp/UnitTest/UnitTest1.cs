using System;
using Xunit;
using Library;

namespace Unitest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            int num = 285;
            string expected = "3 5 19";
            LibraryTest item = new LibraryTest();
            // act
            string actual = item.PrimeFactors(num);
            // assert
            Assert.Equal(expected, actual); 
        }
    }
}
