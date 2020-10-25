using System;

namespace StaticConstructorSample
{
    public class UserPreferences
    {
        static UserPreferences()
        {
            DateTime now = DateTime.Now;

            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                BackColor = ColorEnum.Green;
            }
            else
            {
                BackColor = ColorEnum.Red;
            }
        }

        public static ColorEnum BackColor { get; }
    }
}
