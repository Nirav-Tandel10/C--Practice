using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace Delegates
{

    public delegate void HelloFunctionDelegate(string message);
    internal class Program
    {
                                                                // signature of the delegates should match the signature of the function
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

        static void Main()
        {
            // A DELEGATE  is a type safe funtion pointer
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello from delegate");

        }
    }
}
*/


namespace Delegates
{

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public int Experience { get; set; }

        public void PromoteEmployee(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + " IS PROMOTED");
                }
            }
        }
    }

    class Demo
    {
        public static void Main()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "Nirav", salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Jeel", salary = 6000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Akshat", salary = 10000, Experience = 10 });
            empList.Add(new Employee() { ID = 101, Name = "Meet", salary = 4000, Experience = 2 });

            Employee emp = new Employee();
            emp.PromoteEmployee(empList);

            Console.Read();
        }
    }
}





