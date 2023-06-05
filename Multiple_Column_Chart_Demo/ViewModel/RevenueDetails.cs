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
            FertilityAppData = new List<RevenueDetailModel>();
            MedicationCheckerAppData = new List<RevenueDetailModel>();
            MeditationAppData = new List<RevenueDetailModel>();
            MeditationAppUsers = new List<RevenueDetailModel>();

            FertilityAppData.Add(new RevenueDetailModel(2017, 15.3));
            FertilityAppData.Add(new RevenueDetailModel(2022, 35.9));
            FertilityAppData.Add(new RevenueDetailModel(2027, 52.2));

            MedicationCheckerAppData.Add(new RevenueDetailModel(2017, 201.4));
            MedicationCheckerAppData.Add(new RevenueDetailModel(2022, 370.4));
            MedicationCheckerAppData.Add(new RevenueDetailModel(2027, 642.5));

            MeditationAppData.Add(new RevenueDetailModel(2017, 71.9));
            MeditationAppData.Add(new RevenueDetailModel(2022, 815.8));
            MeditationAppData.Add(new RevenueDetailModel(2027, 1234));

            MeditationAppUsers.Add(new RevenueDetailModel(2022, 28));
        }

        public List<RevenueDetailModel> FertilityAppData { get; set; }
        public List<RevenueDetailModel> MedicationCheckerAppData { get; set; }
        public List<RevenueDetailModel> MeditationAppData { get; set; }

        public List<RevenueDetailModel> MeditationAppUsers { get; set; }
    }
}
