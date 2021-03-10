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

        public static void DisplayBatteryStatus(string property, BatteryLevel.BatteryCondition batteryCondition)
        {
            if (GermanLanguage)
            {
                Console.WriteLine($"Batterie {property} ist {batteryCondition}");
                return;
            }
            Console.WriteLine($"Battery {property} is {batteryCondition}");
        }

        public static void DisplayWarningMessage(BatteryLevel.Warnings warning)
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
