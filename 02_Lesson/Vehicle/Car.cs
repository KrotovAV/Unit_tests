using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car : Vehicle
    {
        //оригинальное поле для авто
        public int Power { get; set; }


        //конструктор + унаследованный конструктор
        public Car(int prise, int maxspeed, int year, int Power)
            : base(prise, maxspeed, year)
        {
            this.Power = Power;
        }
    }
}
