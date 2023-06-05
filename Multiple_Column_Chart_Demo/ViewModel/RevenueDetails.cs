using Multiple_Column_Chart_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Column_Chart_Demo
{
    public class RevenueDetails
    {
        public RevenueDetails()
        {
            AppRevenues = new List<RevenueDetailModel>();
            MeditationAppUsers = new List<RevenueDetailModel>();

            AppRevenues.Add(new RevenueDetailModel("2017", 15.3, 201.4, 71.9));
            AppRevenues.Add(new RevenueDetailModel("2022", 35.9, 370.4, 815.8));
            AppRevenues.Add(new RevenueDetailModel("2027*", 52.2, 642.5, 1234));
            
            MeditationAppUsers.Add(new RevenueDetailModel("2022", 28));
        }

        public List<RevenueDetailModel> AppRevenues { get; set; }
        public List<RevenueDetailModel> MeditationAppUsers { get; set; }
    }
}
