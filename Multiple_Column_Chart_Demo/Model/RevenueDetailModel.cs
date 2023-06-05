using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Column_Chart_Demo
{
    public class RevenueDetailModel
    {
        public RevenueDetailModel(string year, double fertilityAppRevenue, double medicationCheckerAppRevenue, double meditationAppRevenue)
        {
            Year = year;
            FertilityAppRevenue = fertilityAppRevenue;
            MedicationCheckerAppRevenue = medicationCheckerAppRevenue;
            MeditationAppRevenue = meditationAppRevenue;
        }

        public RevenueDetailModel(string year, double meditationAppUsers)
        {
            Year = year;
            MeditationAppUsers = meditationAppUsers;
        }

        public string Year { get; set; }
        public double FertilityAppRevenue { get; set; }
        public double MedicationCheckerAppRevenue { get; set; }
        public double MeditationAppRevenue { get; set; }
        public double MeditationAppUsers { get; set; }
    }
}
