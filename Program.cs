using System;

namespace EmployeeWage
{
    class Program
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUE = 20;
        public const int WR_DAYS_IN_A_MONTH = 20;
        private static int totalEmpWage;

        static void Main(string[] args)
        {
            //Variables
            int empHrs = 0;
            int empWage = 0;
            totalEmpWage = 0;

            //Calculations
            for (int day = 0; day < WR_DAYS_IN_A_MONTH; day++)
            {
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
                empWage = empHrs * EMP_RATE_PER_HOUE;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
