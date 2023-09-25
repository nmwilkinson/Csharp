using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace Chapter6HW 
{
    class Program
    {
        public static void Main(string[] args)
        {
            Question01();
            Question02();
            Question03();
            Question04();
            Console.WriteLine(GetJugglers(10));

        }
        public static void Question01()
        {
            int x = 0;
            Random rnd = new Random();

            Console.WriteLine(Convert.ToInt32(rnd.Next(100000)));
            x = rnd.Next();

            for (int i = 0; i < 1000; i++)
            {

                if (x % 2 == 0)
                {
                    Console.WriteLine(x + "EVEN");
                    x = rnd.Next(6);


                }

                else
                    Console.WriteLine(x + " ODD");
                x = rnd.Next(6);


            }
        }
        public static void Question02()
        {
            var number = 0;

            Console.WriteLine("Enter a number between 1 - 100 Please: ");
            var userChoice = Console.ReadLine();

           
            while (!int.TryParse(userChoice, out number) || number <= 0 || number > 100)
            {
                Console.WriteLine("Try again");
                userChoice = Console.ReadLine();
            }

            Console.WriteLine("Your number is: " + number);
            Console.ReadKey();
        }
        public static void Question03()
        {
            string inValue = "";
            int sumOfScores = 0;
            int counter = 0;
            Console.WriteLine("Please Enter your test Scores.");
            Console.WriteLine("You may enter one score after another. ");
            Console.WriteLine("To Quit please enter value  -99");
            while (inValue != "-99")
            {
                Console.WriteLine("Enter value (-99 to exit)");
                inValue = Console.ReadLine();
                int ConvertedInput = Int16.Parse(inValue);
                sumOfScores += ConvertedInput;
                counter++;

            }
            double average = sumOfScores / counter;
            string grade = "";

            if (average > 90)
                grade = "A";
            else if (average > 80)
                grade = "B";
            else if (average > 70)
                grade = "C";
            else if (average > 60)
                grade = "D";
            else
                grade = "F";


            Console.WriteLine("Your average is :" + average);
            Console.WriteLine("Your final letter grade is: " + grade);


            Console.ReadKey();


        } 
        public static void Question04()
        {
            {
                Console.Write("Enter starting base: ");
                int start = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter ending base: ");
                int end = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("CALCULATING!");
                                            
                Console.Write("n\t");
                for (int i = start; i <= end; i++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
                for (int i = 1; i <= 25; i++)
                {
                    Console.Write(i + "\t");
                    for (int j = start; j <= end; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static string GetJugglers(int v)
        //Question 5
        {
       
            double factr = 0.0;
            int largest = int.MinValue;
            int steps = 0;
            string returnString = v.ToString() + " ";
            int counter = v;
            while (counter > 1)
            {
                if (counter % 2 == 0)
                    factr = 0.5;
                
                else
                    factr = 1.5;
                
                counter = (int)Math.Floor(Math.Pow(counter, factr));
                if(counter > largest)
                {
                    largest = counter;
                }
                steps++;
                returnString += counter.ToString() + " ";
            }
            returnString += "Highwater Mark: " + largest.ToString() + " Steps:  " + steps.ToString();
            Console.ReadKey ();
            return returnString;


        }
        

}

    
}
