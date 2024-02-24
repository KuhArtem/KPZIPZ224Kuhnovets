using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZLab1Lib
{
    public class Money
    {
        public int Dollars { get; private set; }
        public int Cents { get; private set; }

        public Money(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
        }

        public Money Subtract(Money amount)
        {
            if (amount == null)
                throw new ArgumentNullException(nameof(amount), "Сума для віднімання не може бути null");

            var totalCents = (Dollars * 100 + Cents) - (amount.Dollars * 100 + amount.Cents);
            if (totalCents < 0)
                throw new InvalidOperationException("Результат не може бути від'ємним");

            return new Money(totalCents / 100, totalCents % 100);
        }

        public override string ToString() => $"{Dollars}.{Cents:00}";
    }
}
