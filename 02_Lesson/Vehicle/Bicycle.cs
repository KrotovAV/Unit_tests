using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Bicycle : Vehicle
    {
        //оригинальное поле для байков
        public int MaxPassengers { get; set; }

        //конструктор + конструктор базового класса
        public Bicycle(int prise, int maxspeed, int year, int MaxPassengers) : base(prise, maxspeed, year)
        {
            this.MaxPassengers = MaxPassengers;
        }

    }
}

