using System;
using EmployeeWage;

namespace EmployeeWage
{
    public class EmployeeWageCal
    {
        class Program
        {
            public const int IS_FULL_TIME = 1;
            public const int IS_PART_TIME = 2;
            public const int EMP_RATE_PER_HOUR = 20;
            public const int WR_DAYS_IN_A_MONTH = 19;
            public const int NU_OF_WORKING_HRS_IN_A_MONTH = 100;

            public static int computeEmpWage()
            {
                //Variables
                int empHrs = 0;
                int totalEmpHrs = 0;
                int totalWorkingDays = 0;

                //Calculations
                while (totalEmpHrs <= NU_OF_WORKING_HRS_IN_A_MONTH && totalWorkingDays <= WR_DAYS_IN_A_MONTH)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(3);
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        case IS_PART_TIME:
                            empHrs = 4;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Days : " + totalWorkingDays + " Emp Hrs : " + empHrs);
                }
                int totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total Emp Wage : " + totalEmpWage);
                return totalEmpWage;


            }
            static void Main(string[] args)
            {
                computeEmpWage();
            }
        }
    }
}

