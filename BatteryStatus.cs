using System;

namespace BatteryManagementSystem
{
    class StatusMessages
    {
        public static bool GermanLanguage = false;
        
        public static void DisplayBatteryStatus(string property, BatteryCondition.BatteryLevel batteryLevel,IReport report)
        {
            DisplayReport(property, batteryLevel, report);

            if (GermanLanguage)
            {
                Console.WriteLine($"Batterie {property} ist {batteryLevel}");
                return;
            }
            Console.WriteLine($"Battery {property} is {batteryLevel}");
        }

        private static void DisplayReport(string property, BatteryCondition.BatteryLevel batteryLevel, IReport report)
        {
            if (batteryLevel == BatteryCondition.BatteryLevel.High || batteryLevel == BatteryCondition.BatteryLevel.Low)
            {
                report.Logger($"battery {property} threshold is {batteryLevel}");
            }
        }

        public static void DisplayWarningMessage(BatteryCondition.Warnings warning)
        {
            if (GermanLanguage)
            {
                Console.WriteLine($"Warnung Annäherung: {warning}");
                return;
            }

            Console.WriteLine($"Warning Approaching :{warning}");
        }

    }
}
