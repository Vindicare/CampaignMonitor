using CampaignMonitor.Interfaces;
using CampaignMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampaignMonitor.Extensions;

namespace CampaignMonitor.Business
{
    public class DotNetManager : IDotNetManager
    {
        //Requirement 2
        public int[] GetPositiveDivisors(int number)
        {
            return number.DivisibleFactors();
        }

        //Requirement 3
        public double GetSurfaceArea(int sideA, int sideB, int sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0) throw new ArgumentException("InvalidTriangleException");
            var triangle = new Triangle(sideA, sideB, sideC);
            return triangle.SurfaceArea;
        }

        ////Requirement 4
        public int[] FindCommonElements(int[] intArray)
        {
            var intList = intArray.GroupBy(x => x).OrderByDescending(y => y.Count());
            var mostCommonCount = intList.First().Count();
            return intList.Where(x => x.Count() == mostCommonCount).Select(y => y.Key).ToArray();
        }
    }
}
