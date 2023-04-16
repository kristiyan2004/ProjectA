namespace ProjectA
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee("Kristiyan", "Hristov", 18, 'M', 5);
            firstEmployee.Introduce();
            firstEmployee.GoToWork();

            Student student = new Student("Ivan", "Ivanov", 14, 'M', 8);
            student.Introduce();
            student.Study();
        }
    }
}