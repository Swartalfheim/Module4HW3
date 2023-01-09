using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace M4HW3
{
    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
        {
        }
    }
}
