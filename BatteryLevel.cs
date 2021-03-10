using System;
using System.Collections.Generic;
using System.Text;

namespace BatteryManagementSystem
{
    class BatteryLevel
    {
        public enum BatteryCondition
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

        public static BatteryCondition CheckBatteryCondition(float currentValue, float minValue, float maxValue)
        {
            if (CheckMaxCondition(currentValue, maxValue) == BatteryCondition.High)
            {
                return BatteryCondition.High;
            }

            if (CheckMinCondition(currentValue, minValue) == BatteryCondition.Low)
            {
                return BatteryCondition.Low;

            }

            return BatteryCondition.Normal;
        }

        private static BatteryCondition CheckMaxCondition(float currentValue, float maxValue)
        {
            return currentValue > maxValue ? BatteryCondition.High : BatteryCondition.Normal;
        }

        private static BatteryCondition CheckMinCondition(float currentValue, float minValue)
        {
            return currentValue < minValue ? BatteryCondition.Low : BatteryCondition.Normal;
        }

    }
}
