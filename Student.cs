using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDLab4
{
    public class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public double AverageGrade { get; set; }
        public Genders Gender { get; set; }

        public Student()
        {
            Random random = new Random();
            string[] firstNames = { "Іван", "Марія", "Олексій", "Анна", "Петро", "Ольга", "Василь", "Наталія" };
            string[] lastNames = { "Іванов", "Петрова", "Сидоренко", "Коваленко", "Шевченко", "Бондаренко", "Ткаченко", "Мельник" };

            FirstName = firstNames[random.Next(firstNames.Length)];
            LastName = lastNames[random.Next(lastNames.Length)];

            AverageGrade = Math.Round(2 + random.NextDouble() * 3, 2);

            Gender = (Genders)random.Next(Enum.GetValues(typeof(Genders)).Length);
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName},\nСередній бал: {AverageGrade},\nСтать: {Gender}";
        }
    }
}
