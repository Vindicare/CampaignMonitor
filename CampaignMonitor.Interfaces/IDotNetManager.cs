using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignMonitor.Interfaces
{
    public interface IDotNetManager
    {
        int[] GetPositiveDivisors(int number);

        double GetSurfaceArea(int sideA, int sideB, int sideC);

        int[] FindCommonElements(int[] intArray);
    }
}
