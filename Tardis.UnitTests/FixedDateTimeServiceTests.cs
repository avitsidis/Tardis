using System;
using System.Threading.Tasks;
using Xunit;

namespace Tardis.UnitTests
{
    public static class FixedDateTimeServiceTests
    {
        public class CurrentDateTime
        {
            [Fact]
            public async Task Should_AlwaysGiveTheSameDate()
            {
                //Arrange
                var date = new DateTime(1986, 3, 12, 11, 42, 33,100);
                var service = new FixedDateTimeService(date);
                //Act Assert
                Assert.Equal(date, service.CurrentDateTime);
                await Task.Delay(100);
                Assert.Equal(date, service.CurrentDateTime);
            }
        }


    }
}
