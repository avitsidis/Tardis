using System;
using Xunit;


namespace Tardis.UnitTests
{
    public class DefaultDateServiceTests
    {
        public class CurrentDateTime
        {
            [Fact]
            public void Should_AlwaysGiveTheSameDate()
            {
                //Arrange
                var date = DateTime.Now;
                var service = new DefaultDateService();
                var maxDiffMs = TimeSpan.FromMilliseconds(100);
                //Act Assert
                var diffWithNow = DateTime.Now - service.CurrentDateTime;
                Assert.True(diffWithNow < maxDiffMs);
            }
        }
    }
}
