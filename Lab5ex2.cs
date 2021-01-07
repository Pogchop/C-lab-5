using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5ex2
{
    public sealed class Appraisal
    {
        private double bonus;
        public double Caculatebonus (string designation, int tenure, double salary)
        {
            if (designation == "Manager")
            {
                if (tenure <= 5)
                {
                    bonus = salary * 1.5;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            if (designation == "Engineer")
            {
                if (tenure <= 5)
                {
                    bonus = salary * 1.5;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            if (designation == "Technician")
            {
                if (tenure <= 3)
                {
                    bonus = salary * 0.25;
                }
                else if (tenure > 3 && tenure <= 5)
                {
                    bonus = salary * 0.5;
                }
                else
                {
                    bonus = salary * 2;
                }
            }
            return bonus;
            Console.ReadKey();
        }
    }
}
