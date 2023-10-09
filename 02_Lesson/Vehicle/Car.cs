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
        public Car(string company, string model, int year, int numWheels, int speed, int Power) : base(company, model, year, numWheels, speed)
        {
            this.speed = 0;
            this.Power = Power;
        }

        public override int testDrive()
        {
            speed = 60;
            return speed;
        }
        public override int park()
        {
            speed = 0;
            return speed;
        }


    }
}
