using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee noArgs = new Employee();
            noArgs.DateOfHire = DateTime.Parse("01/01/2011");
            noArgs.Department = "Accounting";
            noArgs.Employee_number = 1;
            noArgs.JobDescription = "Treasurer";
            noArgs.MonthlySalary = 2500;
            noArgs.Name = "name";
            Console.WriteLine(noArgs.ToString());

            Employee oneArg = new Employee(123);
            Employee twoArg = new Employee(123, " Tanner");
            Employee sixArg = new Employee(125, "Fred Smith", DateTime.Parse("09/11/2001"), "Test Pilot", 1250, "Aviation");

            Console.WriteLine(oneArg.ToString());
            Console.WriteLine(twoArg.ToString());
            Console.WriteLine(sixArg.ToString());

            //Question 2
            Receipt one = new Receipt(1234, DateTime.Parse("10/10/2022"), 4555, "Marjorie Stewart Baxter",
                "10254 Marble place", " 585 - 585-5885",
                12, "Muffler", 12.99, 1);

            Console.WriteLine("Question 2");
            Console.WriteLine(one.ToString());

            //Question 3
            Date NataliesBirthday = new Date(1997, 10, 13, "october");
            Console.WriteLine("Question 3");
            Console.Write(NataliesBirthday.ToString());

            //Question 4
            Console.WriteLine("Question 4");
            SalesEmployee first = new SalesEmployee("Sal", 13432, 127000.00);
            SalesEmployee second = new SalesEmployee("Roger", 14532, 143000.00);
            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());

            //Question 5
            Console.WriteLine("Question 5");
            Console.WriteLine("Please enter helpfulness Rating: ");
            int helpfulnessRating = Console.Read();
            Console.WriteLine("Please enter clarity Rating: ");
            int clarityRating = Console.Read();
            Console.WriteLine("Please enter course easiness Rating: ");
            int easyRating = Console.Read();

            ProfessorRating firstProf = new ProfessorRating("tim rodgers", 154, helpfulnessRating, easyRating, clarityRating);

            Console.WriteLine(firstProf.ToString());
        }
    }
}
