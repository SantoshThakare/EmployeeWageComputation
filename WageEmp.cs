using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageEmp
    {
       public const int IS_PART_TIME = 1;
       public const int IS_FULL_TIME = 2;
       public const int EMP_RATE_PER_HR = 20;
        public void Wage()
        {
           
            int emHrs = 0;
            int emWage = 0;
            Random random = new Random();
            int empCheck = random .Next(0 , 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    emHrs = 5;
                    break;
                    case IS_FULL_TIME:
                    emHrs = 8;
                    break;
                default:
                    emHrs = 0;
                    break;
            }
            emWage = emHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage is :" + emWage);

        }
    }
}
