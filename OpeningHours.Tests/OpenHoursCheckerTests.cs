using OpeningHours.Lib;
using System;
using Xunit;

namespace OpeningHours.Tests
{
    public class OpenHoursCheckerTests
    {
        [Fact]
        public void ShouldBeClosed20180930_1000()
        {
            var sut = new OpeningHoursChecker();
            bool result = sut.IsOpenAt(new DateTime(2018, 9, 30, 10, 0, 0));
            Assert.Equal(false, result);
        }
        [Fact]
        public void ShouldBeOpen20181001_1100()
        {
            var sut = new OpeningHoursChecker();
            bool result = sut.IsOpenAt(new DateTime(2018, 10, 1, 11, 0, 0));
            Assert.Equal(true, result);
        }
        [Fact]
        public void ShouldBeOpen20181002_1900()
        {
            var sut = new OpeningHoursChecker();
            bool result = sut.IsOpenAt(new DateTime(2018, 10, 2, 19, 0, 0));
            Assert.Equal(true, result);
        }
        [Fact]
        public void ShouldBeClosed20181002_1901()
        {
            var sut = new OpeningHoursChecker();
            bool result = sut.IsOpenAt(new DateTime(2018, 10, 2, 19, 1, 0));
            Assert.Equal(false, result);
        }
    }
}
