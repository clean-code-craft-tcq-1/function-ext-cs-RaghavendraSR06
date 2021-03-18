namespace BatteryManagementSystem
{
    class Battery
    {
        static int Main()
        {
            IReport report = new ConsoleLogger();
            StatusMessages.GermanLanguage = true;
            TestBatteryCondition consoleLogger = new TestBatteryCondition(report);
            consoleLogger.CheckBatteryStatus(40, 84, 0.4f);
            consoleLogger.CheckBatteryStatus(-1, 20, 0.3f);

            StatusMessages.GermanLanguage = false;
            report = new DatabaseLogger();
            TestBatteryCondition dbLogger = new TestBatteryCondition(report);
            dbLogger.CheckBatteryStatus(100, -20, 0.1f);
            return 0;
        }
    }
}

