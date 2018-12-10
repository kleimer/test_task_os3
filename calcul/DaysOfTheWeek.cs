using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcul
{
    class DaysOfTheWeek
  
    {
        private int Day, Month, Year;
        public DaysOfTheWeek(int Day, int Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
        public string DayOfWeek()
        {
            if ((new List<int>() { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }).Contains(this.Day) && (this.Month == 10) && (this.Year == 1582))
            {
                return "В этом году не было такого дня\n      Я сожалею((";
            }
            else
            {
                return DayTo1582();
            }

            
        }

    private string DayTo1582()
        {
            string[] days = { "Воскресенье", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            int k1 = (14 - this.Month) / 12;
            int k2 = this.Year - k1;
            int k3 = this.Month + 12 * k1 - 2;

            return days[Math.Abs(this.Day + k2 + (k2 / 4) - k2 / 100 + k2 / 400 + (31 * k3) / 12) % 7];
        }





    }
}
