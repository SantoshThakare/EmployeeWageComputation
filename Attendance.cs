using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class Attendance
    {
        const int EMP_PRESENT = 0, EMP_ABSENT = 1;
        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == EMP_ABSENT)
            {
                Console.WriteLine("Emploee is Absent");

            }
            if (empCheck == EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }



        }
    }   
}
