using HRAPI;
using System;
namespace SchoolHRAdministration
{
    public enum EmployeeType
    {
        Teacher,
        HeadOfDepartment,
        DeputyHeadMaster,
        HeadMaster
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal totalsalaries = 0;
            List<IEmpolye> employes = new List<IEmpolye>(); 
            SeedData(employes);
            //foreach (IEmpolye employee in employes)
            //{
            //    totalsalaries += employee.Salary;
            //}
            //Console.WriteLine($"Total Annual Salaries (inculding bonus): {totalsalaries}");
            Console.WriteLine($"Total Annual Salaries (inculding bonus) : {employes.Sum(e => e.Salary)}");
            Console.ReadKey();
        }

        public static void SeedData(List<IEmpolye> empolyes)
        {
            IEmpolye teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 1, "Bob", "Fisher", 4000);
            empolyes.Add(teacher1);
            IEmpolye teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher, 2, "Tim", "Dave", 45000);
            empolyes.Add(teacher2);
            IEmpolye headOfDepartment = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 1, "mrinda", "Juice", 50000);
            empolyes.Add(headOfDepartment);
            IEmpolye deputyHeadMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster,1,"kelvin", "medul", 67939);
            empolyes.Add(deputyHeadMaster);
            IEmpolye headMaster = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadMaster, 1, "carel", "shwan", 944623);
            empolyes.Add(headMaster);
        }
    }
    public class Teacher : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary;
            set => base.Salary = value + (value * 0.02m);
        }
    }

    public class HeadOfDepartment : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary;
            set => base.Salary = value + (value * 0.04m);
        }
    }

    public class DeputyHeadMaster : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary;
            set => base.Salary = value + (value * 0.03m);
        }
    }

    public class HeadMaster : EmployeeBase
    {
        public override decimal Salary
        {
            get => base.Salary;
            set => base.Salary = value + (value * 0.05m);
        }
    }
    public static class EmployeeFactory
    {
        public static IEmpolye  GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
        {
            IEmpolye employe = null;
            switch (employeeType)
            {
                case EmployeeType.Teacher:
                    employe=new Teacher { Id=id,FirstName=firstName,LastName=lastName,Salary=salary}; break;
                case EmployeeType.HeadOfDepartment:
                    employe = new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary }; break;
                case EmployeeType.DeputyHeadMaster:
                    employe = new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary }; break;
                case EmployeeType.HeadMaster:
                    employe = new Teacher { Id = id, FirstName = firstName, LastName = lastName, Salary = salary }; break;
                default:
                    break;

            }
            return employe;
        }
    }
}