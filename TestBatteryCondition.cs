namespace BatteryManagementSystem
{
    class TestBatteryCondition
    {
        private IReport report;
       
        public TestBatteryCondition(IReport reporter)
        {
            report = reporter;
        }

        public void CheckBatteryStatus(float temperature, float soc, float chargeRate)
        {
            CheckTemperature(temperature);
            CheckChargeState(soc);
            CheckChargeRate(chargeRate);
        }

        public  void CheckChargeRate(float chargeRate)
        {
            float minChargeRate = 0.3f;
            float maxChargeRate = 0.8f;

            CheckBatteryLevel(chargeRate, minChargeRate, maxChargeRate);
            BatteryCondition.BatteryLevel batteryChargeRate = BatteryCondition.CheckBatteryCondition(chargeRate, minChargeRate, maxChargeRate);
            StatusMessages.DisplayBatteryStatus("Charge Rate", batteryChargeRate, report);
        }
        
        public void CheckChargeState(float soc)
        {
            float minStateOfCharge = 20;
            float maxStateOfCharge = 80;

            CheckBatteryLevel(soc, minStateOfCharge, maxStateOfCharge);
            BatteryCondition.BatteryLevel batteryChargeState = BatteryCondition.CheckBatteryCondition(soc, minStateOfCharge, maxStateOfCharge);
            StatusMessages.DisplayBatteryStatus("State of charge",batteryChargeState, report);
        }

        public void CheckTemperature(float temperature)
        {
            float minTemperature = 0;
            float maxTemperature = 45;

            CheckBatteryLevel(temperature, minTemperature, maxTemperature);
            BatteryCondition.BatteryLevel batteryTemperature = BatteryCondition.CheckBatteryCondition(temperature, minTemperature, maxTemperature);
            StatusMessages.DisplayBatteryStatus("Temperature", batteryTemperature, report);
        }

        public static void CheckBatteryLevel(float chargeValue, float minValue, float maxValue)
        {
            float chargeLevel = BatteryBreachLevel.CalculateBreachLevel(chargeValue);
            BatteryBreachLevel.CheckMinBreachLevel(chargeLevel, chargeValue, minValue);
            BatteryBreachLevel.CheckMaxBreachLevel(chargeLevel, chargeValue, maxValue);
        }
    }
}
