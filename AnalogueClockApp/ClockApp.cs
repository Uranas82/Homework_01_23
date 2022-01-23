using System;

namespace AnalogueClockApp
{
    class ClockApp
    {
        private int _hours;
        private readonly int _minutes;

        public ClockApp(int hours, int minutes)
        {
            _hours = hours;
            _minutes = minutes;
        }

        public void FindAngle()
        {
            if (_hours >= 12)
            {
                _hours -= 12;
            }

            double angleHours = 360 * _hours / 12;
            double angleMinutes = 360 * _minutes / 60;
            angleHours += 30 * _minutes / 60;
            double angleClock = Math.Abs(angleHours - angleMinutes);

            Console.WriteLine($"Angle in degrees between hour and minute arrow: {angleClock} degrees.");
        }
    }
}
