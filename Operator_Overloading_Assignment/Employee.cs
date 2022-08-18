using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Operator_Overloading_Assignment
{
    class Employee : Person
    {


        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (emp1.ID.Equals(emp2.ID))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (!(emp1.ID.Equals(emp2.ID)))
            {
                return true;
            }
            return false;
        }



        public static void Compare(Employee employee1, Employee employee2)
        {
            if (employee1 == employee2)
            {
                Console.WriteLine(employee1.FName + " Id is equal to " + employee2.FName + "'s Id");
            }
            else
            {
                Console.WriteLine(employee1.FName + " Id is NOT equal to " + employee2.FName + "'s Id");

            }
        }
    }

}

