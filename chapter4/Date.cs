
namespace Chapter4
{
    class Date
    {
        public int year;
        public int month;
        public int day;
        public string monthName;

       

        public Date(int year, int month, int day, string monthName)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.monthName = monthName;
        }

        public int Year { get => year; set => year = value; }
        public int Month { get => month; set => month = value; }
        public int Day {  get => day; set => day = value; }
        public string MonthName { get => monthName; set => monthName = value; }
        public override string ToString()
        {
            return month + "" + day + " "+ year + " " + monthName;

        }
    }
}
