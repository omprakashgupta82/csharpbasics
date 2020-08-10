using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics.DelegateFuncActionPredicateDemo
{
    class DelegateFuncActionPredicateDemo
    {
        public delegate Employee MyDelegate(int id);

        public static void Main()
        {
            List<Employee> empList = new List<Employee>() {
                    new Employee() { Name="Om Prakash",ID = 500,Code="EMP-500",Salary = 4522 },
                    new Employee() { Name="Abhay",ID = 501,Code="EMP-501",Salary = 5000 },
                    new Employee() { Name="Oushpendra",ID = 502,Code="EMP-502",Salary = 4000 },
                    new Employee() { Name="Faisal",ID = 503,Code="EMP-503",Salary = 6000 },
                    new Employee() { Name="Kamal",ID = 504,Code="EMP-504",Salary = 8000 }
            };


            // Predicate
            Predicate<Employee> empPredicate = new Predicate<Employee>(FindEmployee);

            //Delegate
            MyDelegate md = (id) => { return empList.Find(empPredicate); };
            Console.WriteLine(md(504));

            // Delegate with anonymous method
            Console.WriteLine(empList.Find(delegate (Employee emp) { return emp.ID == 504; }).ToString());

            // Func
            IEnumerable<Employee> employees = empList.Where(GetEmployees).ToList();

            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }

            //Func with deleaget & anonymous method
            empList.Where(delegate (Employee emp) { return emp.Name.StartsWith("O"); }).ForEach(delegate (Employee e) { Console.WriteLine(e.ToString()); });


            Console.WriteLine();

            Console.ReadKey();
        }

        public static bool FindEmployee(Employee emp)
        {
            return emp.ID == 504;
        }

        Func<Employee, bool> empFunc = new Func<Employee, bool>(GetEmployees);

        public static bool GetEmployees(Employee emp)
        {
            return emp.Name.StartsWith("O");
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int ID { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return string.Format("ID = {0}, Name = {1}", this.ID, this.Name);
        }
    }
}
