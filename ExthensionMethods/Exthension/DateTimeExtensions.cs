using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace System;
static class DateTimeExtensions
{
    public static string ElapsedTime(this DateTime thisObj)
    {
        //This é uma referencia para o próprio objeto
        TimeSpan ts = DateTime.Now.Subtract(thisObj);

        if (ts.TotalHours < 24.0)
        {
            return ts.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
        }
        else
        {
            return ts.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}
