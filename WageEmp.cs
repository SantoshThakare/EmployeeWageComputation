using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageEmp
    {
        public void Wage()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HR = 20;
            int emHrs = 0;
            int emWage = 0;
            Random random = new Random();
            int empCheck = random .Next(0 , 3);
            if (empCheck == IS_PART_TIME)
            {
                emHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                emHrs = 8;
            }
            else
            {
                emHrs = 0;
            }
            emWage = emHrs * EMP_RATE_PER_HR;
            Console.WriteLine("Employee Wage is :" + emWage);

        }
    }
}
