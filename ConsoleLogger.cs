using System;

namespace BatteryManagementSystem
{
    public class ConsoleLogger : IReport
    {
        public void Logger(string message)
        {
            Console.WriteLine("Consolidated Reports");
            Console.WriteLine(message);
        }
    }
}
