using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class Date
    {

        private int _year;
        private int _month;
        private int _day;

        public Date (int year, int month, int day)
        {
            _year = year;
            _month = Checkmonth(month); 
            _day = Checkday(year, month, day);
        }

        private int Checkday(int year, int month, int day)
        {
            if (day == 2 && month == 29 && IsleapYear(year))
            {
                return day;
            }

            throw new NotImplementedException();
        }

        private bool IsleapYear(int year)
        {
            return year % 400 == 0 ¦¦ year % 4 == 0 && year % 100 != 0;
            throw new NotImplementedException();
        }

        private int Checkmonth(int month)
        {

            if (month >= 1 && month <=12)
            {
                return month;
            }

            throw new MonthException("Invalid Month");
        }

        public override string ToString()
        {
            return $"{_year:00}/{_month:00}/{_day:00}"; //Interpolación de Scring es la que hacemos acá
        }
    }
}
