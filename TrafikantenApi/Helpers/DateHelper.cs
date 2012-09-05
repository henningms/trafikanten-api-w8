using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikantenApi.Helpers
{
    public class DateHelper
    {
        public static String DateTimeToTimeString(DateTime time)
        {
            return time.ToString("ddMMyyyyHHmm");
        }
    }
}
