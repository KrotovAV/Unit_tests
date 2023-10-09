using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
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
            string company = "*", model = "**";
            int numWheels = 4, speed = 0, year = 0, Power = 0;

            Console.WriteLine("Введите марку:");
            try
            {
                company = Console.ReadLine();
            }
            catch { }
            Console.WriteLine("Введите модель:");
            try
            {
                model = Console.ReadLine();
            }
            catch { }
                        
            
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            
            Console.WriteLine("Введите количество колес:");
            try
            {
                numWheels = Convert.ToInt32(Console.ReadLine());
                if (numWheels < 4) numWheels = 4;
            }
            catch { }

            //Console.WriteLine("Введите скорость");
            //try
            //{
            //    speed = Convert.ToInt32(Console.ReadLine());
            //}
            //catch { }

            Console.WriteLine("Введите мощьность:");
            try
            {
                Power = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            cars.Add(new Car(company, model, year, numWheels, speed, Power));
        }

        public void AddMotorcycle()
        {
            string company = "*", model = "**";
            int numWheels = 2, speed = 0, year = 0, MaxPassengers = 0;

            Console.WriteLine("Введите марку:");
            try
            {
                company = Console.ReadLine();
            }
            catch { }
            
            Console.WriteLine("Введите модель:");
            try
            {
                model = Console.ReadLine();
            }
            catch { }


            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }

            Console.WriteLine("Введите количество колес:");
            try
            {
                numWheels = Convert.ToInt32(Console.ReadLine());
                if (numWheels > 3) numWheels = 2;
            }
            catch { }

            //Console.WriteLine("Введите скорость");
            //try
            //{
            //    speed = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество пасажиров:");
            try
            {
                MaxPassengers = Convert.ToInt32(Console.ReadLine());
                if (MaxPassengers > 2) MaxPassengers = 1;
            }
            catch { }
            мotorcycles.Add(new Motorcycle(company, model, year, numWheels, speed, MaxPassengers));
        }


        public void GetAllCar()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine("Марка: {0}, Модель: {1}, Год: {2}, Колес: {3}, Скорость: {4}, Мощность: {5};", car.Company, car.Model, car.Year, car.NumWheels, car.Speed, car.Power);
            }
        }
        public void GetCarForTest()
        {
            string findModel = "*";
            Console.WriteLine("Что бы выбрать введите модель:");
            try
            {
               findModel = Console.ReadLine();
            }
            catch { }

            foreach (Car car in cars)
            {
                if (findModel.Equals(car.Model))
                { 
                    car.testDrive();
                    Console.WriteLine("Марка: {0}, Модель: {1}, Год: {2}, Колес: {3}, Скорость: {4}, Мощность: {5};", car.Company, car.Model, car.Year, car.NumWheels, car.Speed, car.Power);
                }
                else
                {
                    Console.WriteLine($"Модель {findModel} не найдена");
                }
            }
        }
        public void GetCarToParking()
        {
            string findModel = "*";
            Console.WriteLine("Что бы выбрать введите модель:");
            try
            {
                findModel = Console.ReadLine();
            }
            catch { }

            foreach (Car car in cars)
            {
                if (findModel.Equals(car.Model))
                {
                    car.park();
                    Console.WriteLine("Марка: {0}, Модель: {1}, Год: {2}, Колес: {3}, Скорость: {4}, Мощность: {5};", car.Company, car.Model, car.Year, car.NumWheels, car.Speed, car.Power);
                }
                else
                {
                    Console.WriteLine($"Модель {findModel} не найдена");
                }
            }
        }
        public void GetAllMotorcycle()
        {
            foreach (Motorcycle motorcycle in мotorcycles)
            {
                Console.WriteLine("Марка: {0}, Модель: {1}, Год: {2}, Колес: {3}, Скорость: {4}, Макс.пассажиров: {5};", motorcycle.Company, motorcycle.Model, motorcycle.Year, motorcycle.NumWheels, motorcycle.Speed, motorcycle.MaxPassengers);
            }
        }
        public void GetMotorcycleForTest()
        {
            string findModel = "*";
            Console.WriteLine("Что бы выбрать введите модель:");
            try
            {
                findModel = Console.ReadLine();
            }
            catch { }

            foreach (Motorcycle motorcycle in мotorcycles)
            {
                if (findModel.Equals(motorcycle.Model))
                {
                    motorcycle.testDrive();
                    Console.WriteLine("Марка: {0}, Модель: {1}, Год: {2}, Колес: {3}, Скорость: {4}, Макс.пассажиров: {5};", motorcycle.Company, motorcycle.Model, motorcycle.Year, motorcycle.NumWheels, motorcycle.Speed, motorcycle.MaxPassengers);
                }
                else
                {
                    Console.WriteLine($"Модель {findModel} не найдена");
                }
            }
        }

        public void GetMotorcycleToParking()
        {
            string findModel = "*";
            Console.WriteLine("Что бы выбрать введите модель:");
            try
            {
                findModel = Console.ReadLine();
            }
            catch { }

            foreach (Motorcycle motorcycle in мotorcycles)
            {
                if (findModel.Equals(motorcycle.Model))
                {
                    motorcycle.park();
                    Console.WriteLine("Марка: {0}, Модель: {1}, Год: {2}, Колес: {3}, Скорость: {4}, Макс.пассажиров: {5};", motorcycle.Company, motorcycle.Model, motorcycle.Year, motorcycle.NumWheels, motorcycle.Speed, motorcycle.MaxPassengers);
                }
                else
                {
                    Console.WriteLine($"Модель {findModel} не найдена");
                }
            }
        }
    }
}
