using System;
using System.Buffers;

namespace HW8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            PerformTasks();
        }
        static void PerformTasks()
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            bool isLocalCompany;
            Console.WriteLine("Is the company local?");

            if (Console.ReadLine().Equals("Yes"))
            {
                isLocalCompany = true;
            }
            else
            {
                isLocalCompany = false;
            }

            Employee employee = new Employee();
            Company company = new Company(); // ობიექტები (by creating an  object, we encapsulate all relevant information)

            Console.WriteLine("State your first name");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("State your last name");
            employee.LastName = Console.ReadLine();

            Console.WriteLine("Enter your age");
            employee.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your position");
            employee.Position = Console.ReadLine();

            employee.HoursWorked = new int[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"Enter hours worked on day {i + 1}");
                employee.HoursWorked[i] = int.Parse(Console.ReadLine());
            }
            double weeklyIncome = employee.CalculateIncome();
            Console.WriteLine($"Weekly income is: {weeklyIncome}");

            double taxes = company.CalculateTaxes(weeklyIncome, isLocalCompany);
            Console.WriteLine($"Taxes to be paid: {taxes}");
        }
        static void Task2()
        {
            Student student = new Student();
            Console.WriteLine("Enter your name");
            student.Name = Console.ReadLine();

            Console.WriteLine("Enter your age");
            student.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("What year did you enroll?");
            student.EnrollmentYear = int.Parse(Console.ReadLine());

            Teacher teacher = new Teacher();
            Console.WriteLine("Enter teacher's name");
            teacher.Name = Console.ReadLine();

            Console.WriteLine("Is this teacher certified?");
            teacher.HasCertification = Console.ReadLine() == "Yes"; // will set to true if the answer is Yes

            Console.WriteLine($"Student has {student.YearsLeftTillGraduation()} years left until graduation");

            string randomSubject = student.GetRandomSubject();
            Console.WriteLine($"Random subject chosen is {randomSubject}");

            string response = teacher.SubjectResponse(randomSubject);
            Console.WriteLine(response);
        }
    }
}