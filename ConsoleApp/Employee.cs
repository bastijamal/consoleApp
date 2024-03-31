using System;
namespace ConsoleApp
{
	public class Employee
	{
        private int _salary;
        public string Name;
        public string Surname;
        public int Age;
        public int Departmentno; //id


        public int Salary {
            get {
                return _salary;
            }
            set {
                if (value > 0)
                {
                    _salary = value;
                }

                else
                {
                    Console.WriteLine("Maash 0 ve menfi ola bilmez!");
                }
            }
        }


    }
}

