using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampaignMonitor.Models
{
    public class Triangle
    {
        public Triangle(int sideA, int sideB, int sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public int SideA { get; set; }

        public int SideB { get; set; }

        public int SideC { get; set; }

        //Calculated using Heron's Formula        
        public double SurfaceArea
        {
            get
            {
                var semiPerimeter = .5 * (SideA + SideB + SideC);
                return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
            }
        }
    }
}
