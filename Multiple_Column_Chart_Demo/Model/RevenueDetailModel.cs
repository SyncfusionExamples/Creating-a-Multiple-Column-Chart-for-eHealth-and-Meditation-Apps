using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Column_Chart_Demo
{
    public class RevenueDetailModel
    {
        public RevenueDetailModel(string year, double fertilityApp, double medicationCheckerApp, double meditationApp)
        {
            Year = year;
            FertilityApp = fertilityApp;
            MedicationCheckerApp = medicationCheckerApp;
            MeditationApp = meditationApp;
        }

        public RevenueDetailModel(string year, double meditationAppUserPercentage)
        {
            Year = year;
            MeditationAppUserPercentage = meditationAppUserPercentage;
        }

        public string Year { get; set; }
        public double FertilityApp { get; set; }
        public double MedicationCheckerApp { get; set; }
        public double MeditationApp { get; set; }
        public double MeditationAppUserPercentage { get; set; }
    }
}
