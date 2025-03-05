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
            // Создаем объект класса RelayTeam
            RelayTeam team = new RelayTeam();

            // Добавляем студентов и их результаты
            team.AddStudent("Иванов", 12.5);
            team.AddStudent("Петров", 11.8);
            team.AddStudent("Сидоров", 13.2);
            team.AddStudent("Кузнецов", 11.5);
            team.AddStudent("Васильев", 12.0);
            team.AddStudent("Смирнов", 12.7);

            // Получаем команду из четырех лучших бегунов
            var bestRunners = team.GetBestRunners(4);

            // Выводим результат
            Console.WriteLine("Команда из четырех лучших бегунов:");
            foreach (var runner in bestRunners)
            {
                Console.WriteLine($"{runner.Surname} - {runner.Result} сек");
            }
        }
    }

    class Student
    {
        public string Surname { get; set; }
        public double Result { get; set; }

        public Student(string surname, double result)
        {
            Surname = surname;
            Result = result;
        }
    }

    class RelayTeam
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(string surname, double result)
        {
            students.Add(new Student(surname, result));
        }

        public List<Student> GetBestRunners(int count)
        {
            // Сортируем студентов по результатам (от лучшего к худшему)
            var sortedStudents = students.OrderBy(s => s.Result).ToList();

            // Возвращаем указанное количество лучших бегунов
            return sortedStudents.Take(count).ToList();
        }
    }
}
