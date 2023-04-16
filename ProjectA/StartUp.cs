namespace ProjectA
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee("Kristiyan", "Hristov", 18, 'M', 5);
            firstEmployee.Introduce();
        }
    }
}