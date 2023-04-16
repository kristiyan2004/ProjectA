using ProjectA.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Employee : Person, IEmployee
    {
        public int WorkExperience { get; set; }

        public Employee(string firstName, string lastName, int age, char gender, int workExperience) : base(firstName, lastName, age, gender)
        {
            this.WorkExperience = workExperience;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Name: {base.FirstName} {base.LastName} | Gender: {base.Gender} | Age: {base.Age} years old | Work Experience: {this.WorkExperience} years");
        }

        public void GoToWork()
        {
            Console.WriteLine("It was a tough day at work! +$200.");
        }
    }
}
