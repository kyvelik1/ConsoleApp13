using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2
{
    class Program
    {
        static void Main()
        {
            // Массив фамилий студентов
            string[] surnames = { "Иванов", "Петров", "Сидоров", "Кузнецов", "Васильев", "Смирнов" };

            // Массив результатов в беге на 100 метров (в секундах)
            double[] results = { 12.5, 11.8, 13.2, 11.5, 12.0, 12.7 };

            // Объединяем фамилии и результаты в один массив кортежей
            var students = surnames.Zip(results, (surname, result) => (surname, result)).ToArray();

            // Сортируем студентов по результатам (от лучшего к худшему)
            var sortedStudents = students.OrderBy(s => s.result).ToArray();

            // Выбираем четырех лучших бегунов
            var bestRunners = sortedStudents.Take(4);

            // Выводим результат
            Console.WriteLine("Команда из четырех лучших бегунов:");
            foreach (var runner in bestRunners)
            {
                Console.WriteLine($"{runner.surname} - {runner.result} сек");
            }
        }
    }
}
