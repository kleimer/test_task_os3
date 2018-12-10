using System;
namespace calcul
{

    public static class Calendar
    {
        public int Day, Month, Year;
        public Calendar(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
        private day_of_week(int Day, int Month, int Year)
        {
            if (Year >= 1583)
            {
                int k1 = (14 - Month) / 12;
                int k2 = Year - k1;
                int k3 = Month + 12 * a - 2;
                return (Day + k2 + k2 / 4 - k2 / 100 + k / 400 + (31 * k3) / 12) / 7;
            }
        }
        private MyConsole()
        
        {
            string hello = "Привет мир";
            Console.WriteLine(hello);
            Console.WriteLine("Добро пожаловать в C#!");
            Console.WriteLine("Пока мир...");
            Console.WriteLine(24.5);

            Console.ReadKey();
        }



    }
}