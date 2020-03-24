using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company_v1_core
{
    class Employee
    {
        private String name;
        private int salaryPerMonth;

        public Employee(String name, int salaryPerMonth)
        {
            this.name = name;
            this.salaryPerMonth = salaryPerMonth;
        }

        public String GetName()
        {
            return name;
        }

        public virtual int GetSalaryPerMonth()
        {
            return salaryPerMonth;
        }
    }
}
