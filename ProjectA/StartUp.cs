namespace ProjectA
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee("Maria", "Hristova", 18, 'F', 5);
            firstEmployee.Introduce();
            firstEmployee.GoToWork();

            Student student = new Student("Ivan", "Ivanov", 14, 'M', 8);
            student.Introduce();
            student.Study();
        }
    }
}