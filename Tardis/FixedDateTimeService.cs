using System;

namespace Tardis
{
    public class FixedDateTimeService : IDateService
    {
        public FixedDateTimeService(DateTime fixedDateTime)
        {
            CurrentDateTime = fixedDateTime;
        }

        public DateTime CurrentDateTime { get; }
    }
}
