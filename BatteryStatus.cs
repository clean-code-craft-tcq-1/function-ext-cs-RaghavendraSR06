using System;

namespace BatteryManagementSystem
{
    class BatteryStatus
    {
        public static bool GermanLanguage = false;

        public static void CheckBatteryStatus(float temperature, float soc, float chargeRate)
        {
            TestBatteryCondition.CheckTemperature(temperature);
            TestBatteryCondition.CheckChargeState(soc);
            TestBatteryCondition.CheckChargeRate(chargeRate);
        }

        public static void DisplayBatteryStatus(string property, BatteryCondition.BatteryLevel batteryLevel)
        {
            if (GermanLanguage)
            {
                Console.WriteLine($"Batterie {property} ist {batteryLevel}");
                return;
            }
            Console.WriteLine($"Battery {property} is {batteryLevel}");
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
