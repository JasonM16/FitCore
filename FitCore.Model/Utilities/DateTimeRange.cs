using System;

namespace FitCore.Model.Utilities
{
    public class DateTime
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public DateTime(System.DateTime start, System.DateTime end)
        {
            Guard.Against.PrecedesDate(start, end, "start");
            Start = start;
            End = end;
        }

        public DateTime(System.DateTime start, TimeSpan duration) : this(start, start.Add(duration))
        {
        }
        protected DateTime() { }

        public int DurationInMinutes()
        {
            return (End - Start).Minutes;
        }

        public DateTime NewEnd(System.DateTime newEnd)
        {
            return new DateTime(this.Start, newEnd);
        }
        public DateTime NewDuration(TimeSpan newDuration)
        {
            return new DateTime(this.Start, newDuration);
        }
        public DateTime NewStart(System.DateTime newStart)
        {
            return new DateTime(newStart, this.End);
        }

        public static DateTime CreateOneDayRange(System.DateTime day)
        {
            return new DateTime(day, day.AddDays(1));
        }

        public static DateTime CreateOneWeekRange(System.DateTime startDay)
        {
            return new DateTime(startDay, startDay.AddDays(7));
        }

        public bool Overlaps(DateTime dateTimeRange)
        {
            return this.Start < dateTimeRange.End &&
                this.End > dateTimeRange.Start;
        }
    }
}
