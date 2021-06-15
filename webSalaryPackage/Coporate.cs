using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webSalaryPackage
{
    public class Coporate:companies
    {

        public string hours { get; set; }
        public double calsalarypackage(string company, string work_type, string emp_salary, string hours)
        {
            double salarypackageamount = 0;
            int salary = Int32.Parse(emp_salary);

            try
            {

                

                double workhours = double.Parse(hours, System.Globalization.CultureInfo.InvariantCulture);
                if (work_type == "casual")
                {
                    return 0;
                }
                else
                {
                    if (salary <= 100000)
                    {
                        salarypackageamount = salary * 1 / 100;
                    }
                    else
                    {
                        salarypackageamount = salary * 0.1 / 100;
                    }

                    if (work_type == "part-time")
                    {
                        salarypackageamount = part_time(ref salarypackageamount, workhours);
                    }

                    return Math.Round(salarypackageamount,2);
                }
            }
            catch (Exception)
            {
                return 0;
            }

        }
        //  	If an employee is part-time then they are only entitled to a
        //  percentage of the limit determined by the previous rules.
        private static double part_time(ref double amountsalarypackage, double workhours)
        {
            double a = workhours / 38;
            amountsalarypackage = amountsalarypackage * a;
            return amountsalarypackage;
        }
       

    }

}
