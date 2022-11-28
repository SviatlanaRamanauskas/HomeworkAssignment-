namespace ReizTechAssignment.ClockTask
{
    class AnalogueClock
    {
        private static void Main()
        {
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double cycleAngle = 360;

            double hourMax = 12;
            double minutesMax = 60;
            int oneHourInDs = 30;
            double gradusAddToHours;
            double differenceHoursInDs = 0;
            double differenceMinutesInDs = 0;
            if (hours == 0 && minutes > 0 && minutes <= 59) //time: 00:48
            {
                gradusAddToHours = minutes * oneHourInDs / 60; // (Proporsion) 60 is amount of min in 1 hour // 24
                differenceHoursInDs = (hourMax - hours) * oneHourInDs - gradusAddToHours; // 336
                differenceMinutesInDs = (minutesMax - minutes) * 6;// 6 is amount of degrees in 1 minute //(60-48) * 6 = 72
            }
            else if (minutes == 0 && hours > 0 && hours <= 12) //time: 07:00
            {
                gradusAddToHours = 0; // no need
                differenceHoursInDs = (hourMax - hours) * oneHourInDs - gradusAddToHours;// (12 - 7) * 30 = 150;
                differenceMinutesInDs = (minutesMax - minutes) * 6; //360;
            }
            else if (minutes == 0 && hours == 0) // can skip but I leave for visualisation
            {
                gradusAddToHours = 0;
                differenceHoursInDs = 0;
                differenceMinutesInDs = 0;
            }
            else if (hours > 0 && hours <= 12 && minutes > 0 && minutes <= 59) //time: 10:57
            {
                gradusAddToHours = minutes * oneHourInDs / 60; // 28.5  
                differenceHoursInDs = (hourMax - hours) * oneHourInDs - gradusAddToHours; // 31.5
                differenceMinutesInDs = (minutesMax - minutes) * 6; // 18
            }


            double smallestAngle = Math.Abs(differenceHoursInDs - differenceMinutesInDs);

            if (smallestAngle > 180)
            {
                smallestAngle = cycleAngle - smallestAngle;
            }
            Console.WriteLine(smallestAngle);
        }
    }
}
