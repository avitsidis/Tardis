using System;
using Xunit;


namespace Tardis.UnitTests
{
    public class DefaultDateServiceTests
    {
        public class CurrentDateTime
        {
            [Fact]
            public async Task Should_AlwaysGiveTheSameDate()
            {
                //Arrange
                var date = new DateTime(1986, 3, 12, 11, 42, 33, 100);
                var service = new DefaultDateService();
                //Act Assert
                var diffWithNow = DateTime.Now - service.CurrentDateTime;
                Assert.True(diffWithNow < Timespan.FromMilliseconds(100));
                Task.Delay(100);
                Assert.Equals(date, service.CurrentDateTime);
            }
        }
    }
}
