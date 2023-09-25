using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Chapter5
{
    static class Constants
    {
        public const decimal FEDTAX = .18M;
        public const decimal RETIREMENT = .1M;
        public const decimal SOCIALSECURITY = .06M;
    }
    class SalaryEmployee
    {
        private string id;
        private string fullname;
        private decimal salaryAmount;
        public SalaryEmployee(string id, string fullname, decimal salaryAmount)
        {
            this.id = id;
            this.fullname = fullname;
            this.salaryAmount = salaryAmount;
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Fullname
        {
            get
            {
                return fullname;
            }
            set
            {
                fullname = value;
            }
        }
        public decimal SalaryAmount
        {
            get
            {
                return salaryAmount;
            }
            set
            {
                salaryAmount = value;
            }
        }

        public virtual decimal TakeHomePay
        {
            get
            {
                return SalaryAmount - (SalaryAmount * Constants.FEDTAX) - (SalaryAmount * Constants.RETIREMENT) - (SalaryAmount * Constants.SOCIALSECURITY);
            }
        }
    }
}