namespace BatteryManagementSystem
{
    class TestBatteryCondition
    {
        public static void CheckChargeRate(float chargeRate)
        {
            float minChargeRate = 0.3f;
            float maxChargeRate = 0.8f;

            CheckBatteryLevel(chargeRate, minChargeRate, maxChargeRate);
            BatteryCondition.BatteryLevel batteryChargeRate = BatteryCondition.CheckBatteryCondition(chargeRate, minChargeRate, maxChargeRate);
            BatteryStatus.DisplayBatteryStatus("Charge Rate", batteryChargeRate);
        }
        
        public static void CheckChargeState(float soc)
        {
            float minStateOfCharge = 20;
            float maxStateOfCharge = 80;

            CheckBatteryLevel(soc, minStateOfCharge, maxStateOfCharge);
            BatteryCondition.BatteryLevel batteryChargeState = BatteryCondition.CheckBatteryCondition(soc, minStateOfCharge, maxStateOfCharge);
            BatteryStatus.DisplayBatteryStatus("State of charge",batteryChargeState);
        }

        public static void CheckTemperature(float temperature)
        {
            float minTemperature = 0;
            float maxTemperature = 45;

            CheckBatteryLevel(temperature, minTemperature, maxTemperature);
            BatteryCondition.BatteryLevel batteryTemperature = BatteryCondition.CheckBatteryCondition(temperature, minTemperature, maxTemperature);
            BatteryStatus.DisplayBatteryStatus("Temperature", batteryTemperature);
        }

        public static void CheckBatteryLevel(float chargeValue, float minValue, float maxValue)
        {
            float chargeLevel = BatteryBreachLevel.CalculateBreachLevel(chargeValue);
            BatteryBreachLevel.CheckMinBreachLevel(chargeLevel, chargeValue, minValue);
            BatteryBreachLevel.CheckMaxBreachLevel(chargeLevel, chargeValue, maxValue);
        }
    }
}
