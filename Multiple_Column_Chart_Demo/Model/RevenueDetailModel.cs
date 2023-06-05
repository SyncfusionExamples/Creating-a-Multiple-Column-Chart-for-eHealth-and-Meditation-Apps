using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Column_Chart_Demo
{
    public class RevenueDetailModel
    {
        public RevenueDetailModel(double year, double revenue)
        {
            Year = year;
            Revenue = revenue;
        }

        public double Year { get; set; }
        public double Revenue { get; set; }
    }
}
