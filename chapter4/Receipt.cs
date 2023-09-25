using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Receipt
    {
        private int receiptNum;
        private DateTime dateOfPurchase;
        private int employeeNumber;
        private string custName;
        private string custAddress;
        private string custPhone;
        private int itemNumber;
        private string itemDescription;
        private double unitPrice;
        private int unitsPurchased;

        public Receipt()
        {
        }
        public Receipt(int receiptNum, DateTime dateOfPurchase, int employeeNumber,
            string custName, string custAddress, string custPhone, int itemNumber,
            string itemDescription,
            double unitPrice, int unitsPurchased)
        {
            this.receiptNum = receiptNum;
            //  this.dateOfPurchase = dateOfPurchase;
            this.employeeNumber = employeeNumber;
            this.custName = custName;
            this.custAddress = custAddress;
            this.custPhone = custPhone;
            this.itemNumber = itemNumber;
            this.itemDescription = itemDescription;
            this.unitPrice = unitPrice;
            this.unitsPurchased = unitsPurchased;
        }

        public int recipetNum { get => receiptNum; set => receiptNum = value; }
        public DateTime DateOfPurchase { get => dateOfPurchase; set => dateOfPurchase = value; }

        public int employee_number { get => employee_number; set => employee_number = value; }

        public string CustName { get => custName; set => custName = value; }

        public string CustAddress { get => custAddress; set => custAddress = value; }
        public string CustPhone { get => custPhone; set => custPhone = value; }
        public int ItemNumber { get => itemNumber; set => itemNumber = value; }

        public string ItemDescription { get => itemDescription; set => itemDescription = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public int UnitsPurchased { get => unitsPurchased; set => UnitsPurchased = value; }



        public override string ToString()
        {
            return receiptNum + " " + DateOfPurchase + " " +  employeeNumber + " " + CustName + " " + CustAddress + "" + CustPhone + " " + 
                ItemNumber + " " + ItemDescription + " " + UnitPrice + " " + UnitsPurchased;
        }

    }
}