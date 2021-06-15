using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webSalaryPackage
{
    public class PBI:companies
    {
        private static double salarypackageamount;

        public string education_type { get; set; }


        public double calsalarypackage(string company, string work_type, string emp_salary, string education_type)

        {
            double salarypackageamount = 0;
            try
            {

                bool iseducated = false;
                int salary = Int32.Parse(emp_salary);


                // check if the employee is educated
                if (education_type == "bachelor" || education_type == "postgraduate" || education_type == "docorate")
                {
                    iseducated = true;
                }
                // call method for full time method
                if (work_type == "full-time")
                {
                    salarypackageamount = full_time(salary);
                }
                // recall method for part_time
                else if (work_type == "part-time")
                {
                    salarypackageamount = part_time(salary);
                }
                // call casual method
                else
                {
                    salarypackageamount = casual(salary);
                }
                if (iseducated)
                {
                    salarypackageamount = educated(salarypackageamount,salary);

                }

                return Math.Round(salarypackageamount, 2);

            }
            catch (Exception)
            {

                return 0;
            }
        }

        private static double casual(int salary)
        {
            return salary * 10 / 100;
        }

        private static double part_time(int salary)
        {
            double pt_salary = salary * 80 / 100;
            double a = 32.55 * pt_salary / 100;
            if (a < 50000)
            {
                salarypackageamount = a;
            }
            else
                salarypackageamount = 50000;
            return salarypackageamount;
        }

        private static double full_time(int salary)
        {

            double a = 32.55 * salary / 100;
            if (a < 50000)
            {
                salarypackageamount = a;
            }
            else
                salarypackageamount = 50000;
            return salarypackageamount;
        }

        // bonus for educated person
        private static double educated(double salarypackageamount,int salary)
        {
            double b = salary * 1 / 100;
            salarypackageamount = salarypackageamount + b + 2000;
            return salarypackageamount;
        }
    }
}