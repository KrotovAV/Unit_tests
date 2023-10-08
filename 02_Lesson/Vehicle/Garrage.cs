using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Garrage
    {
        public List<Car> cars = new List<Car>();
        public List<Motorcycle> мotorcycles = new List<Motorcycle>();
   
        public void AddCar()
        {
            int prise = 0, maxspeed = 0, year = 0, Power = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите максимальную скорость");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите мощьность:");
            try
            {
                Power = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            cars.Add(new Car(prise, maxspeed, year, Power));
        }

        public void AddMotorcycle()
        {
            int prise = 0, maxspeed = 0, year = 0, MaxPassengers = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите максимальную скорость");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите количество пасажиров:");
            try
            {
                MaxPassengers = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            мotorcycles.Add(new Motorcycle(prise, maxspeed, year, MaxPassengers));
        }


        public void GetAllCar()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine("Цена: {0}, Максимальная скорость: {1}, Год: {2}, Мощьность: {3};", car.Price, car.Maxspeed, car.Year, car.Power);
            }
        }

        public void GetAllMotorcycle()
        {
            foreach (Motorcycle motorcycle in мotorcycles)
            {
                Console.WriteLine("Цена: {0}, Максимальная скорость: {1}, Год: {2}, Максимум пасажиров: {3};", motorcycle.Price, motorcycle.Maxspeed, motorcycle.Year, motorcycle.MaxPassengers);
            }
        }

    }
}
