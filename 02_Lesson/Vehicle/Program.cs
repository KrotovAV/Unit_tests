using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {

        static void Main(string[] args)
        {
            Garrage garrage = new Garrage();

            while (true)
            {
                int i = 0;
                Console.WriteLine(@"Выберите нужное Вам действие:
        1. Добавить в список мотоцикл;
        2. Добавить в список машину;
        3. Вывести все мотоциклы из списка;
        4. Вывести все машины из списка;
        5. Взять машину на тестдрайв;
        6. Вернуть машину на паркинг;
        7. Взять мотоцикл на тестдрайв;
        8. Вернуть мотоцикл на паркинг;
        9. Выход.");
                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
                switch (i)
                {
                    case 1: garrage.AddMotorcycle(); break;
                    case 2: garrage.AddCar(); break;
                    case 3: Console.WriteLine("Мотоциклы:"); garrage.GetAllMotorcycle(); break;
                    case 4: Console.WriteLine("Машины:"); garrage.GetAllCar(); break;

                    case 5: garrage.GetCarForTest(); break;
                    case 6: garrage.GetCarToParking(); break;
                    case 7: garrage.GetMotorcycleForTest(); break;
                    case 8: garrage.GetMotorcycleToParking(); break;

                    case 9: return;
                    default: Console.WriteLine(""); break;
                }
            }
        }
    }
}
