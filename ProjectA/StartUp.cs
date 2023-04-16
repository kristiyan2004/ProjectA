namespace ProjectA
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee("Maria", "Hristova", 24, 'F', 1);
            firstEmployee.Introduce();
            firstEmployee.GoToWork();

            Employee secondEmployee = new Employee("Kristiyan", "Hristov", 35, 'M', 5);
            secondEmployee.Introduce();
            secondEmployee.GoToWork();

            Student student = new Student("Ivan", "Ivanov", 14, 'M', 8);
            student.Introduce();
            student.Study();
        }
    }
}