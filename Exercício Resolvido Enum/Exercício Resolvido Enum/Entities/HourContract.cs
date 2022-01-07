using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_Resolvido_Enum.Entities
{
    class HourContract
    {
        public DateTime date { get; set; }

        public double valuePerHour { get; set; }

        public int Hours { get; set; }

        public void constructor()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.date = date;
            this.valuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * valuePerHour;
        }

    }
}
