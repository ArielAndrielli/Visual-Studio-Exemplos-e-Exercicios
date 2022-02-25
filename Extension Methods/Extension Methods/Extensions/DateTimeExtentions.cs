using System.Globalization;

namespace System
{
 static class DateTimeExtentions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                return duration.TotalDays.ToString("F2", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
