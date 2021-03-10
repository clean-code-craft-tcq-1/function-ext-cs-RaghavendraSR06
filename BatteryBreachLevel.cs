namespace BatteryManagementSystem
{
    class BatteryBreachLevel
    {
        public static float CalculateBreachLevel(float chargeLevel)
        {
            return (float)(0.05 * chargeLevel);
        }

        public static void CheckMinBreachLevel(float chargeLevel, float chargeValue, float minValue)
        {
            float chargeRate = chargeLevel + minValue;

            if (minValue <= chargeValue && chargeValue <= chargeRate)
            {
                BatteryStatus.DisplayWarningMessage(BatteryLevel.Warnings.Discharge);
            }
        }

        public static void CheckMaxBreachLevel(float chargeLevel, float chargeValue, float maxValue)
        {
            float chargeRate = maxValue - chargeLevel;

            if (chargeValue <= maxValue && chargeRate <= maxValue)
            {
                BatteryStatus.DisplayWarningMessage(BatteryLevel.Warnings.ChargePeak);
            }
        }
    }
}
