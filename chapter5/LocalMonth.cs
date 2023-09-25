namespace Chapter5
{
    class LocalMonth

    {
        public int Month;

        public LocalMonth(int month)
        {
            Month = month;
        }
        public override string ToString()
        {
            return Month.ToString();
        }
    }
}