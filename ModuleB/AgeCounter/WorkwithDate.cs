using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AgeCounter
{
    public static class WorkwithDate
    {
        public static int Age(this DateTime birthdate)
        {
            var age = DateTime.Today.Year - birthdate.Year;
            return (DateTime.Today.AddYears(-age)  >= birthdate) ? age : age - 1;
        }

        public static string EnumarableToString(this IEnumerable<DateTime> dateListTimes)
        {
            var ourText = new StringBuilder();
            {
                foreach (var date in dateListTimes)
                {
                    ourText.AppendLine(date.ToString(CultureInfo.InvariantCulture));
                }
                return ourText.ToString();
            }
        }
    }
}
