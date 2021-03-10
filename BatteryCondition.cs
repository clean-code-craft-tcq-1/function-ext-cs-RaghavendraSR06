using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagementSystem
{
    class BatteryCondition
    {
        public enum BatteryLevel
        {
            Low,
            Normal,
            High
        }

        public enum Warnings
        {
            Discharge,
            ChargePeak
        }

        public static BatteryLevel CheckBatteryCondition(float currentValue, float minValue, float maxValue)
        {
            if (CheckMaxCondition(currentValue, maxValue) == BatteryLevel.High)
            {
                return BatteryLevel.High;
            }

            if (CheckMinCondition(currentValue, minValue) == BatteryLevel.Low)
            {
                return BatteryLevel.Low;

            }

            return BatteryLevel.Normal;
        }

        private static BatteryLevel CheckMaxCondition(float currentValue, float maxValue)
        {
            return currentValue > maxValue ? BatteryLevel.High : BatteryLevel.Normal;
        }

        private static BatteryLevel CheckMinCondition(float currentValue, float minValue)
        {
            return currentValue < minValue ? BatteryLevel.Low : BatteryLevel.Normal;
        }

    }
}
