using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignMonitor.Extensions
{
    public static class ExtensionFactory
    {
        public static bool IsNullOrEmpty(this String str)
        {
            return str == null || str == string.Empty;
        }

        public static int[] DivisibleFactors(this int num)
        {
            return (from i in Enumerable.Range(1, num)
                   where num % i == 0
                   select i).ToArray();
        }
    }
}
