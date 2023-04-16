using ProjectA.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Student : Person, IStudent
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int age, char gender, int grade) : base(firstName, lastName, age, gender)
        {
            this.Grade = grade;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Name: {base.FirstName} {base.LastName} | Gender: {base.Gender} | Age: {base.Age} years old | Grade: {this.Grade}");
        }

        public void Study()
        {
            Console.WriteLine("I hate physics but I cannot do anything about it...");
        }
    }
}
