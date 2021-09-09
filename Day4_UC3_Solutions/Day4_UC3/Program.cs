using System;

namespace Day4_UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1_EmployeeAttendance.GetAttendance();
            UC2_EmpWage.EmpWage();
            UC3_PartTimeEmpWage.PartTimeEmpWage();
            UC4_EmpWageUsingSwitch.EmpWageUsingSwitch();
            UC5_CalculateWagesFor20DaysInMonth.CalculateWagesFor20DaysInMonth();
            UC6_CalculateWageTill100HrsOr20IsReached.CalculateWageTill100HrsOr20IsReached();
            UC7_ComputeEmpWageUsingClassMethod.ComputeEmpWage();
            UC8_ComputeEmpWageForMultipleCompanies.ComputeEmpWage("abc", 4, 5, 7);
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
