using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int EnrollmentYear { get; set; }

        public int YearsLeftTillGraduation()
        {
            int yearsStudied = DateTime.Now.Year - EnrollmentYear;
            return Math.Max (0, 4 - yearsStudied); // 4 წლიანი ფაკულტეტი
        }
        public string GetRandomSubject()
        {
            string[] subjects = { "English", "Math", "Chemistry" };
            Random random = new Random(); 
            return subjects[random.Next (subjects.Length)]; // იღებს რენდომ ინდექსს და აბრუნებს ნებისმიერ საგანს
        }
    }
}