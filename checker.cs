namespace BatteryManagementSystem
{
    class Battery
    {
        static int Main()
        {
            BatteryStatus.GermanLanguage = true;
            BatteryStatus.CheckBatteryStatus(40, 84, 0.4f);
            BatteryStatus.CheckBatteryStatus(-1, 20, 0.3f);
            BatteryStatus.GermanLanguage = false;
            BatteryStatus.CheckBatteryStatus(100, -20, 0.1f);
            return 0;
        }
    }
}
