using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Lorry : Vehicle
    {
        public int MaxCapacity { get; set; }

        public Lorry(int prise, int maxspeed, int year, int MaxCapacity)
            : base(prise, maxspeed, year)
        {
            this.MaxCapacity = MaxCapacity;
        }
    }
}
