using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCtorInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
			var emp1 = new Employee();
			var emp2 = new Employee(1);//int empId
			var emp3 = new Employee('A');//char code

		}
    }

	class Employee
	{
		public int IdNumber { get; set; }
		public double Salary { get; set; }

		public Employee() : this(999, 0)
		{ }
		public Employee(int empId) : this(empId, 0)
		{ }

		public Employee(int empId, double sal)
		{
			IdNumber = empId;
			Salary = sal;
		}

		public Employee(char code) : this(111, 100000)
		{ }
	}
}
