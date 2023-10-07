using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterApp1
{
    public static class Calc
    {
        public static double СalcDiscount(double p, double d)
        {
            if (p <= 0)
                throw new ArgumentOutOfRangeException("Цена", p, "Цена не может быть положительной");
            else if (d < 0)
                throw new ArgumentOutOfRangeException("Скидка", d, "Скидка не может быть меньше нуля");
            else if (d >= 100)
                throw new ArgumentOutOfRangeException("Скидка", d, "Скидка не может быть больше 100% или равной 100%");
            else
                return p - p * d / 100;
        }


    }
}
