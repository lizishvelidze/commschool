using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal class Teacher
    {
        public string Name { get; set; }
        public bool HasCertification { get; set; }
    
    public string SubjectResponse(string subject)
    {
        Random rand = new Random();
            if (subject == "Math")
            {
                int num1 = rand.Next(1, 101);
                int num2 = rand.Next(1, 101);
                return $"Result for maths: {num1 + num2}";
            }
            else if (subject == "English")
            {
                return "Hello. This is a random text in English!";
            }
            else if (subject == "Chemistry")
            {
                return "Result for Chemistry: C6H12O6 (Glucose)";
            }
            else
            {
                return "Sorry. I am not competent in this subject.";
            }

        }
    }
}