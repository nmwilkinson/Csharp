using System;
namespace Chapter5

{
    class Program
    {
        static void Main(string[] args)
        {
            //Number 1
            Console.WriteLine(Aquarium());
            //Number 2
            int monthNumber = TestInputInteger("Enter the number of the month: ");
            LocalMonth month = new LocalMonth(monthNumber);
            //Console.WriteLine(month.MonthName, " has ", month.DaysOfMonth, " days. ");
            Console.WriteLine(month.ToString());
            //Number 3
            Number3();
            //4
            string inName;
            string empType;  //Salary or Hourly
            string inputBuffer;
            Console.WriteLine("Enter employee name:");
            inName = Console.ReadLine();
            Console.WriteLine("(S)alary or (H)ourly: ");
            inputBuffer = Console.ReadLine();
            empType = inputBuffer.ToUpper();

            if (empType == "S")
            {
                SalaryEmployee emp = new SalaryEmployee("123", "Jeff", 250.00M);
                Console.WriteLine(emp.TakeHomePay);
            }
            else
            {
                HourlyEmployee emp = new HourlyEmployee(1234, "Not Jeff", 10.0, 40.0);
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }
        private static void Number3()
        {
            double weight = TestInputDouble("Enter your weight in kilograms: ");
            double height = TestInputDouble("Enter your height in meters: ");
            if (height > 2.72)
            {
                height = 2.72;
            }
            double bmi = calcBodyMassIndex(weight, height);
            string description = "";
            if (bmi < 18.5)
                description = "Underweight";
            else if (bmi >= 18.5 && bmi < 25)
                description = "Normal";
            else if (bmi >= 25 && bmi < 30)
                description = "Overweight";
            else
                description = "Tubby";
            Console.WriteLine("Weight: " + weight + " Height: " + height + " BMI: " + bmi + " " + description);
            Console.WriteLine(description);
        }
        private static double calcBodyMassIndex(double weight, double height)
        {
            Console.WriteLine("In method: ", weight, " ", height);
            double retVal = weight / (Math.Pow(height, 2));
            return retVal;
        }
        static string Aquarium()
        {
            string retVal = "";
            double pH = TestInputDouble("Enter the pH level of the aquarium:");

            if (pH < 7.0)
                retVal = "Acidic";
            else if (pH == 0.0)
                retVal = "Bad data.";
            else if (pH > 7.0)
            {
                retVal = "Alkaline";
            }
            else
            {
                retVal = "Neutral";
            }
            return retVal;
        }
        private static double TestInputDouble(string msg)
        {
            string inValue;
            Console.WriteLine(msg);
            inValue = Console.ReadLine();
            double v1 = 0.0;
            if (double.TryParse(inValue, out v1) == false)
            {
                Console.WriteLine("You did not enter the correct data type.");
            }
            return v1;
        }
        private static int TestInputInteger(string msg)
        {
            string inValue;
            Console.WriteLine(msg);
            inValue = Console.ReadLine();
            int v1 = 0;
            if (int.TryParse(inValue, out v1) == false)
            {
                Console.WriteLine("You did not enter the correct data type.");
            }
            return v1;
        }
    }
}