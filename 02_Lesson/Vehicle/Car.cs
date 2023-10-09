using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car : Vehicle
    {
        //оригинальное поле для авто
        public int Power { get; set; }


        public Car()
        {
            company = "*";
            model = "**";
            year = 1900;
            numWheels = 4;
            speed = 0;
            this.Power = Power;
        }

        //конструктор + унаследованный конструктор
        public Car(string company, string model, int year, int numWheels, int speed, int Power) : base(company, model, year, numWheels, speed)
        {
            this.Power = Power;
        }

        public override int TestDrive()
        {
            speed = 60;
            return speed;
        }
        public override int Park()
        {
            speed = 0;
            return speed;
        }


    }
}
