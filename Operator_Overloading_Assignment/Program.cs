using System;

namespace Operator_Overloading_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.ID = 122;
            employee1.FName = "John";

            Employee employee2 = new Employee();
            employee2.ID = 123;
            employee2.FName = "Adam";

            Employee employee3 = new Employee();
            employee3.ID = 123;
            employee3.FName = "adam";

            Employee.Compare(employee1, employee2);
            Employee.Compare(employee1, employee3);
            Employee.Compare(employee2, employee3);

        }
    }
}
