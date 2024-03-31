using System;
using System.Xml.Linq;

namespace ConsoleApp
{
	public class Department
	{

        Employee[] employees;


        public Department()
		{
            employees = new Employee[0];

		}

        public void AddEmployee(Employee employee)
        {
            Employee[] newEmployes = new Employee[employees.Length + 1];

            for (int i = 0; i <employees.Length; i++)
            {
                newEmployes[i] = employees[i];
            }

            newEmployes[newEmployes.Length - 1] = employee;
            employees = newEmployes;

        }


        //DEPARTMENT NAME YOXSA NO(NOMRE) OLDUGUNU ANLAMADIGIM UCHUN,NOMRE==ID KIMI GOTURDUM

        public Employee GetAllEmployees(int Departmentno)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Departmentno == Departmentno)
                {
                    return employee;
                }
            }

            return null;
        }


        public void ShowFullInfo()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Surname: {employee.Surname}  Age: {employee.Age} Departmentno: {employee.Departmentno}  Salary: {employee.Salary}");
            }
        }


    }
}

