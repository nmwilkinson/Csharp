namespace Chapter5
{
    class HourlyEmployee
    {
        private string name;
        private int ID;
        private double hourlyRate;
        private double hoursWorked;
        private double takeHomePay;
        public HourlyEmployee(int ID, string name, double hourlyRate, double hoursWorked)
        {
            this.name = name;
            this.ID = ID;
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;

            takeHomePay = (hoursWorked * hourlyRate);
        }
        public override string ToString()
        {
            return takeHomePay.ToString();
        }
    }
}