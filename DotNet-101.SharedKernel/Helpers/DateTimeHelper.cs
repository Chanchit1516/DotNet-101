using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.SharedKernel.Helpers
{
    public static class DateTimeHelper
    {
        public static DateTime Now()
        {
            return DateTime.Now;
        }

        public static DateTime UtcNow()
        {
            return DateTime.UtcNow;
        }
    }
}
