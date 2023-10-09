using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Motorcycle : Vehicle
    {
        //оригинальное поле для мотоциклов
        public int MaxPassengers { get; set; }

        //конструктор + конструктор базового класса
        public Motorcycle(string company, string model, int year, int numWheels, int speed,  int MaxPassengers) : base(company, model, year, numWheels, speed)
        {
            this.speed = 0;
            this.MaxPassengers = MaxPassengers;
        }

        public override int testDrive()
        {
            speed = 75;
            return speed;
        }
        public override int park()
        {
            speed = 0;
            return speed;
        }
    }
}
