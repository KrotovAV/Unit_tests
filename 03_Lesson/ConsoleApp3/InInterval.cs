using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class InInterval
    {
        public static bool NumberInInterval(int namber, int leftBorder, int rightBorder)
        {
            if (leftBorder > rightBorder) 
            {
                throw new ArgumentException("Неверные данные! Левая граница интервала больше правой");
            }
            if (leftBorder == rightBorder) 
            {
                throw new ArgumentException("Неверные данные! Левая и правая граница интервалов равны");
            }
                if (leftBorder <= namber && namber <= rightBorder)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
