using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webSalaryPackage
{
    public class Hospital:companies
    {
        public string education_type { get; set; }

        
        public double calsalarypackage(string company, string work_type, string emp_salary, string education_type)
        {
            double salarypackageamount = 0;
            bool iseducated = false;
            int salary = Int32.Parse(emp_salary);
            iseducated = check_education(education_type, iseducated);
            try
            {
                
                salarypackageamount = cal_sal(salary);
                //If an employee is working full-time, their package limit is increased by 9.5% and an
                //additional 1.2% of their salary is added on top of that.
                if (work_type=="full-time")
                {
                    salarypackageamount = salarypackageamount * 9.5 / 100 + salary * 1.2 / 100;
                }
                if (iseducated)
                {
                    salarypackageamount = educated(salarypackageamount);
                }


                return Math.Round(salarypackageamount, 2);


            }
            catch (Exception)
            {

                return 0;
            }
        }

        private static double cal_sal(int salary)
        {
            double salarypackageamount;
            double a = 20 * salary / 100;
            if (a > 10000 && a<30000)
            {
                salarypackageamount = a;
            }
            else
                salarypackageamount = 10000;
            return salarypackageamount;
        }

        private static bool check_education(string education_type, bool iseducated)
        {
            if (education_type == "bachelor" || education_type == "postgraduate" || education_type == "docorate")
            {
                return true;
            }

            return iseducated;
        }

        private static double educated(double salarypackageamount)
        {

            salarypackageamount = salarypackageamount + 5000;
            return salarypackageamount;
        }

    }
}