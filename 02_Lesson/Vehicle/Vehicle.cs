using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Vehicle
{
    abstract class Vehicle
    {
        
        protected string company, model; 
        protected int year, numWheels, speed;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int NumWheels
        {
            get { return numWheels; }
            set { if (value > 0) numWheels = value; }
        }

        // свойство Максимальная скорость
        public int Speed
        {
            get { return speed; }
            //set { if (value > 0) speed = value; }
            set { speed = value; }
        }
        // свойство Год выпуска
        public int Year
        {
            get { return year; }
            set { if (value <= DateTime.Today.Year) year = value; }
        }

        //конструктор класа!!!

        public Vehicle(string company, string model, int numWheels, int speed, int year)
        {
            this.Company = company;
            this.Model = model;
            this.NumWheels = numWheels;
            this.Speed = speed;
            this.Year = year;
        }

        abstract public int testDrive();
        abstract public int park();
    }
}
