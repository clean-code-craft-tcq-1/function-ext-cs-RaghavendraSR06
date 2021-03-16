using System;

namespace BatteryManagementSystem
{
    class DatabaseLogger : IReport
    {
        public void Logger(string message)
        {
            Console.WriteLine("Consolidated Reports");
            Console.WriteLine(message);
        }
    }
}
