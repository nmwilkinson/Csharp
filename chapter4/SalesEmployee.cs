using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class SalesEmployee
    {
        const double FEDTAXRATE = .18;
        const double SOCSECTAXRATE = 0.06;
        const double RETIREMENTSAVINGSRATE = .10;

        private String name;
        private int employeeID;
        private double sales;
        private double takeHomePay;
        private double employeeCut;
        private double fedTaxWithholding;
        private double socSecTaxWithholding;
        private double retirementWithholding;
        


        public SalesEmployee(string name, int employeeID, double sales)
        {
            this.name = name;
            this.employeeID = employeeID;
            this.sales = sales;
           // this.takeHomePay = sales ;
            this.employeeCut = sales * .07;
            this.fedTaxWithholding = employeeCut * FEDTAXRATE;
            this.socSecTaxWithholding = employeeCut * SOCSECTAXRATE;
           // this retirementWithholding = employeeCut * RETIREMENTSAVINGSRATE;
            this.takeHomePay = employeeCut - fedTaxWithholding - socSecTaxWithholding - retirementWithholding;

        }
        public override String ToString()
        {
            return " Employee Name: " + name + " Fedetal Taxes: " + fedTaxWithholding +" Social Security: " +  socSecTaxWithholding +" Retirement Fund: " +  retirementWithholding + " Take Home Pay" + takeHomePay;
        }
    }
}