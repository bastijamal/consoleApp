using System;
using System.Diagnostics;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        #region Console App Task

        //   Employee class  (kitablar)
        // - Name
        // - Surname
        // - Age
        // - Salary


        //Employee class yaradırsınız və bu xüsusiyyətləri olur :
        //Name, Surname, Age, Salary.Name,DepartmentNo,
        //Surname, Age, Salary və DepartmentName dəyəri təyin olunmamış student yaradıla bilminməməlidir
        // Employees - departmentdəki işçilərdən ibarət array-dir:

        //Department class  (library)
        // - Employees
        // - AddEmployee()
        // - ShowEmployeeInfo()
        // - GetAllEmployees()


        // AddEmployee() - bir employee obyekti qəbul edir parametr olaraq və qəbul etdiyi
        // employee obyektini Employees array-ə əlavə edir.

        // ShowEmployeeInfo() - işçinin məlumatlarını ekranda göstərir.
        // GetAllEmployees() - bütün işçiləri geri qaytarır


        //Daha sonra Proqram bizə menu seçimi göstərir aşağıdakı kimi:
        //1. Employee əlavə et  (AddEmployee)
        //2. Bütün işçilərə bax (ShowEmployeeInfo)
        //0. Proqramı bitir (Exit)

        //Bu menu pəncərəsi görsəndikdən dərhal sonra proqram bizdən bir seçim etməyimizi istəməlidir
        //Əgər 1-i seçsək Employee yaratmaq üçün lazım olan bütün dataları console-dan daxil edirik
        //və bir employee obyekti yaradıb department obyektimizin AddEmployee metodu ilə onu departmentə əlavə edirik.


        //    Əgər 2-ni seçsək,yaratmış olduğumuz department obyektindəki bütün işçilərin məlumatları
        //    console pəncərəsində göstərilməlidir.


        //Əgər 0-ı seçsək proses bitməlidir.

        #endregion



        Department department = new Department();

        Employee employee1 = new Employee()
        {
            Name="Basti",
            Surname="Jamal",
            Age=20,
            Salary=1500,
            Departmentno=1,
        };

        Employee employee2 = new Employee()
        {
            Name = "Nazrin",
            Surname = "Karimova",
            Age = 19,
            Salary = 150,
            Departmentno = 2,
        };

        department.AddEmployee(employee1);
        department.AddEmployee(employee2);

        Console.WriteLine(department.GetAllEmployees(2).Surname);

        department.ShowFullInfo();

        Console.WriteLine("-----------------------------------");

        //Console Pragrami


        bool exit = false;

        do
        {

            Console.WriteLine("Welcome to our Project!");
            Console.WriteLine("1.Ishci elave edin");
            Console.WriteLine("2.Butun Ishcilere baxin");
            Console.WriteLine("0.Exit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Ishci elave edin:");
                    Console.WriteLine("Bunlari daxil edin -ishcinin adi,soyadi,yashi,maashi,department nomresi, maashi");

                    string name = Console.ReadLine();
                    string surname = Console.ReadLine();

                    int age = Convert.ToInt32(Console.ReadLine());
                    int salary = Convert.ToInt32(Console.ReadLine());
                    int departmentno = Convert.ToInt32(Console.ReadLine());

                    Employee newEmployee = new Employee
                    {

                        Name = name,
                        Surname = surname,
                        Age = age,
                        Salary = salary,
                        Departmentno = departmentno
                    };

                    department.AddEmployee(newEmployee);
                    break;


                case "2":
                    department.ShowFullInfo();
                    break;

                case "0": exit=true;
                    break;

                default:
                    Console.WriteLine("Duzgun deyer daxil edin!");
                    break;
            }

        } while (exit!=true);
            

    }


}

